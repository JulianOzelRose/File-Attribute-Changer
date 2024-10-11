using System;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;

/*
    Julian O. Rose
    File-Attribute-Changer
    9-16-2023
*/

namespace File_Attribute_Changer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string FormatFileSize(long fileSizeBytes)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            int order = 0;
            double size = fileSizeBytes;

            while (size >= 1024 && order < sizes.Length - 1)
            {
                order++;
                size /= 1024;
            }

            return $"{size:0.##} {sizes[order]}";
        }

        public void WriteAttributes()
        {
            // Format timestamps
            DateTime modifiedDateTime = dtpDateModified.Value.Date + dtpTimeModified.Value.TimeOfDay;
            DateTime createdDateTime = dtpDateCreated.Value.Date + dtpTimeCreated.Value.TimeOfDay;
            DateTime accessedDateTime = dtpDateAccessed.Value.Date + dtpTimeAccessed.Value.TimeOfDay;

            try
            {
                // Remove read-only attribute temporarily
                File.SetAttributes(filePath, File.GetAttributes(filePath) & ~FileAttributes.ReadOnly);

                // Write timestamp attributes
                File.SetLastWriteTime(filePath, modifiedDateTime);
                File.SetCreationTime(filePath, createdDateTime);
                File.SetLastAccessTime(filePath, accessedDateTime);

                // Handle writing Read-only attribute
                if (chkReadOnly.Checked && !isReadOnly)
                {
                    File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.ReadOnly);
                    isReadOnly = true;
                }
                else if (!chkReadOnly.Checked && isReadOnly)
                {
                    File.SetAttributes(filePath, File.GetAttributes(filePath) & ~FileAttributes.ReadOnly);
                    isReadOnly = false;
                }

                // Handle writing Hidden attribute
                if (chkHidden.Checked && !isHidden)
                {
                    File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.Hidden);
                    isHidden = true;
                }
                else if (!chkHidden.Checked && isHidden)
                {
                    File.SetAttributes(filePath, File.GetAttributes(filePath) & ~FileAttributes.Hidden);
                    isHidden = false;
                }

                // Handle writing Compression attribute and NTFS compression
                if (chkCompressed.Checked && !isCompressed)
                {
                    if (isEncrypted)
                    {
                        // Decrypt the file first
                        File.Decrypt(filePath);
                        File.SetAttributes(filePath, File.GetAttributes(filePath) & ~FileAttributes.Encrypted);
                        isEncrypted = false;
                    }

                    if (IsNTFS(filePath))
                    {
                        // Enable NTFS compression and set Compression attribute
                        EnableNTFSCompression(filePath);
                        File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.Compressed);
                        isCompressed = true;
                    }
                }
                else if (!chkCompressed.Checked && isCompressed)
                {
                    if (IsNTFS(filePath))
                    {
                        // Disable NTFS compression and clear Compression attribute
                        DisableNTFSCompression(filePath);
                        File.SetAttributes(filePath, File.GetAttributes(filePath) & ~FileAttributes.Compressed);
                        isCompressed = false;
                    }
                }

                // Handle writing Encryption attribute and NTFS encryption
                if (chkEncrypted.Checked && !isEncrypted)
                {
                    // Encrypt the file
                    File.Encrypt(filePath);
                    File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.Encrypted);
                    isEncrypted = true;
                }
                else if (!chkEncrypted.Checked && isEncrypted)
                {
                    // Decrypt the file
                    File.Decrypt(filePath);
                    File.SetAttributes(filePath, File.GetAttributes(filePath) & ~FileAttributes.Encrypted);
                    isEncrypted = false;
                }

                // Handle writing Index attribute
                //if (chkIndexed.Checked && !isIndexed)
                //{
                //    File.SetAttributes(filePath, File.GetAttributes(filePath) | ~FileAttributes.NotContentIndexed);
                //    isIndexed = true;
                //}
                //else if (!chkIndexed.Checked && isIndexed)
                //{
                //    File.SetAttributes(filePath, File.GetAttributes(filePath) & FileAttributes.NotContentIndexed);
                //    isIndexed = false;
                //}

                // Handle writing System attribute
                if (chkSystem.Checked && !isSystem)
                {
                    File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.System);
                    isSystem = true;
                }
                else if (!chkSystem.Checked && isSystem)
                {
                    File.SetAttributes(filePath, File.GetAttributes(filePath) & ~FileAttributes.System);
                    isSystem = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static void EnableNTFSCompression(string filePath)
        {
            // Modify the NTFS compression state
            IntPtr handle = NativeMethods.CreateFile(filePath, NativeMethods.GENERIC_READ | NativeMethods.GENERIC_WRITE,
                0, IntPtr.Zero, NativeMethods.OPEN_EXISTING, 0, IntPtr.Zero);

            if (handle != IntPtr.Zero)
            {
                try
                {
                    int compressionFormat = NativeMethods.COMPRESSION_FORMAT_LZNT1;
                    uint bytesReturned;
                    NativeMethods.DeviceIoControl(handle, NativeMethods.FSCTL_SET_COMPRESSION,
                        ref compressionFormat, sizeof(int), IntPtr.Zero, 0, out bytesReturned, IntPtr.Zero);
                }
                finally
                {
                    NativeMethods.CloseHandle(handle);
                }
            }
        }

        static void DisableNTFSCompression(string filePath)
        {
            // Modify the NTFS compression state
            IntPtr handle = NativeMethods.CreateFile(filePath, NativeMethods.GENERIC_READ | NativeMethods.GENERIC_WRITE,
                0, IntPtr.Zero, NativeMethods.OPEN_EXISTING, 0, IntPtr.Zero);

            if (handle != IntPtr.Zero)
            {
                try
                {
                    int compressionFormat = 0;
                    uint bytesReturned;
                    NativeMethods.DeviceIoControl(handle, NativeMethods.FSCTL_SET_COMPRESSION,
                        ref compressionFormat, sizeof(int),
                        IntPtr.Zero, 0, out bytesReturned, IntPtr.Zero);
                }
                finally
                {
                    NativeMethods.CloseHandle(handle);
                }
            }
        }

        public static bool IsNTFS(string filePath)
        {
            try
            {
                string driveName = Path.GetPathRoot(filePath);
                string wmiQuery = "SELECT * FROM Win32_Volume WHERE Name = '";

                // Query WMI to retrieve file system information for the drive
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(wmiQuery + driveName.Replace("\\", "\\\\") + "'"))
                {
                    ManagementObjectCollection disks = searcher.Get();

                    foreach (ManagementObject disk in disks)
                    {
                        object fileSystemObject = disk["FileSystem"];
                        string fileSystem = fileSystemObject != null ? fileSystemObject.ToString() : null;

                        if (fileSystem != null && fileSystem.Equals("NTFS", StringComparison.OrdinalIgnoreCase))
                        {
                            // NTFS file system found
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public static class NativeMethods
        {
            // NTFS compression methods
            public const uint GENERIC_READ = 0x80000000;
            public const uint GENERIC_WRITE = 0x40000000;
            public const uint OPEN_EXISTING = 3;
            public const uint FSCTL_SET_COMPRESSION = 0x0009C040;
            public const int COMPRESSION_FORMAT_LZNT1 = 2;

            [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
            public static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode,
                IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

            [System.Runtime.InteropServices.DllImport("kernel32.dll")]
            [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
            public static extern bool CloseHandle(IntPtr hObject);

            [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
            [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
            public static extern bool DeviceIoControl(IntPtr hDevice, uint dwIoControlCode, ref int lpInBuffer,
                int nInBufferSize, IntPtr lpOutBuffer, int nOutBufferSize, out uint lpBytesReturned, IntPtr lpOverlapped);
        }

        private bool isReadOnly;
        private bool isHidden;
        private bool isSystem;
        private bool isIndexed;
        private bool isCompressed;
        private bool isEncrypted;
        private string filePath;
        private string fileName;
        private string directoryPath;
        private string fileSizeFormatted;
        private string fileExtension;
        private string lastDirectory = "c:\\";
        private long fileSizeBytes;

        // Application type
        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SHGetFileInfo(string pszPath,
            uint dwFileAttributes,
            out SHFILEINFO psfi,
            uint cbSizeFileInfo,
            uint uFlags);

        // Application type
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public int iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        }

        public const uint SHGFI_DISPLAYNAME = 0x000000200;      // Display name
        public const uint SHGFI_TYPENAME = 0x000000400;         // Type name

        private void BrowseFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = lastDirectory;
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get filename and path
                    filePath = openFileDialog.FileName;
                    fileName = Path.GetFileName(filePath);
                    directoryPath = Path.GetDirectoryName(filePath);
                    lastDirectory = directoryPath;

                    // Parse file attributes
                    FileAttributes attributes = File.GetAttributes(filePath);
                    FileInfo fileInfo = new FileInfo(filePath);
                    DateTime lastAccessTime = File.GetLastAccessTime(filePath);
                    fileSizeBytes = fileInfo.Length;
                    fileSizeFormatted = FormatFileSize(fileSizeBytes);
                    fileExtension = Path.GetExtension(filePath);
                    isReadOnly = (attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly;
                    isHidden = (attributes & FileAttributes.Hidden) == FileAttributes.Hidden;
                    isSystem = (attributes & FileAttributes.System) == FileAttributes.System;
                    isCompressed = (attributes & FileAttributes.Compressed) == FileAttributes.Compressed;
                    isIndexed = (attributes & FileAttributes.NotContentIndexed) != FileAttributes.NotContentIndexed;
                    isEncrypted = (attributes & FileAttributes.Encrypted) == FileAttributes.Encrypted;

                    // Display file attributes
                    txtFileLocation.Text = directoryPath;
                    txtFilename.Text = fileName;
                    txtFileSize.Text = fileSizeFormatted;
                    chkHidden.Checked = isHidden;
                    chkReadOnly.Checked = isReadOnly;
                    chkSystem.Checked = isSystem;
                    chkIndexed.Checked = isIndexed;
                    chkCompressed.Checked = isCompressed;
                    chkEncrypted.Checked = isEncrypted;

                    // Display date attributes
                    dtpDateModified.Value = File.GetLastWriteTime(filePath);
                    dtpDateCreated.Value = File.GetCreationTime(filePath);
                    dtpDateAccessed.Value = File.GetLastAccessTime(filePath);

                    // Display time attributes
                    dtpTimeModified.Value = new DateTime(lastAccessTime.Year, lastAccessTime.Month, lastAccessTime.Day)
                        .Add(File.GetLastWriteTime(filePath).TimeOfDay);
                    dtpTimeCreated.Value = new DateTime(lastAccessTime.Year, lastAccessTime.Month, lastAccessTime.Day)
                        .Add(File.GetCreationTime(filePath).TimeOfDay);
                    dtpTimeAccessed.Value = new DateTime(lastAccessTime.Year, lastAccessTime.Month, lastAccessTime.Day)
                        .Add(lastAccessTime.TimeOfDay);

                    // Get file type
                    SHFILEINFO shfi = new SHFILEINFO();
                    IntPtr hIcon = SHGetFileInfo(filePath, 0, out shfi, (uint)Marshal.SizeOf(shfi), SHGFI_TYPENAME | SHGFI_DISPLAYNAME);

                    // Update button states
                    btnApply.Enabled = true;
                    btnOK.Enabled = true;

                    if (hIcon != IntPtr.Zero)
                    {
                        txtFileType.Text = shfi.szTypeName + " (" + fileExtension + ")";
                    }
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            BrowseFile();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            WriteAttributes();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            WriteAttributes();
            Application.Exit();
        }

        private void chkEncrypted_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEncrypted.Checked && chkCompressed.Checked)
            {
                chkCompressed.Checked = false;
            }
        }

        private void chkCompressed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCompressed.Checked && chkEncrypted.Checked)
            {
                chkEncrypted.Checked = false;
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiReportBug_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JulianOzelRose/File-Attribute-Changer/issues");
        }

        private void tsmiBrowse_Click(object sender, EventArgs e)
        {
            BrowseFile();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}