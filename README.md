# File Attribute Changer
A simple file attribute modification tool. It allows users to manipulate various
attributes and properties associated with files, such as modifying timestamps, setting
attributes like read-only, hidden, compressed, encrypted, and system. The purpose of
this program is to better understand the Windows API and the .NET Framework,
specifically with file manipulation and bitmasks.

![File-Attribute-Changer-UI](https://github.com/JulianOzelRose/File-Attribute-Changer/assets/95890436/608ddf0c-72f2-4f22-afa0-c67b6e66a1e3)

## Installation and use
This program does not require any setup. Simply navegate to the [Release](https://github.com/JulianOzelRose/File-Attribute-Changer/tree/master/File-Attribute-Changer/bin/x64/Release)
folder, then download ```File-Attribute-Changer.exe```, and then run it. Once open, click ```Browse``` to select a file of your choice. From there,
you can modify timestamps, encrypt/decrypt the file, compress/decompress the file, set the file to read-only, or set it as a system file. When finished just click
```Apply``` or ```OK``` for the application to save and exit.

## File attributes
The Windows file attributes enum has 16 different fields. This program reads and manipulates 7 of those. A file can only either be compressed or encrypted,
and a read-only file cannot be modified. All of these fields can be parsed using bitwise operators. For example, you can find out whether or not a file
is read-only by using:

```
FileAttributes attributes = File.GetAttributes(filePath);
bool isReadOnly = (attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly;
```

###       ```FileAttributes```                           ###
| **Attribute**          | **Description**                 |
| :---                   | :---                            |
| Normal                 | The file has no attributes      |
| Compressed             | The file is compressed          |
| Hidden                 | The file is hidden              |
| Encrypted              | The file's data is encrypted    |
| ReadOnly               | The file is read-only           |
| System                 | The file is a system file       |
| NotContentIndexed      | The file won't be indexed       |
| Offline                | The file is offline/unavailable |

## Encryption and compression
This tool uses ```System.IO``` for encryption and decryption. For compression and decompression, it uses Windows native methods. It checks to ensure that the
file system is NTFS before proceeding with compression. If a compression operation is performed on an encrypted file, the tool
decrypts the file first. Note that for encryption and compression operations, it is not enough to just modify the bitmask; the encryption
and compression operations themselves must be done in addition to the bitmask modifications.

## Sources
- [FileAttributes Enum](https://learn.microsoft.com/en-us/dotnet/api/system.io.fileattributes?view=net-7.0)
- [File Attribute Constants](https://learn.microsoft.com/en-us/windows/win32/fileio/file-attribute-constants)
- [FSCTL_SET_COMPRESSION](https://learn.microsoft.com/en-us/windows/win32/api/winioctl/ni-winioctl-fsctl_set_compression)
- [DeviceIoControl](https://learn.microsoft.com/en-us/windows/win32/api/ioapiset/nf-ioapiset-deviceiocontrol)
- [SHGetFileInfo](https://learn.microsoft.com/en-us/previous-versions/windows/embedded/aa453700(v=msdn.10))
- [Invoking a Synchronous Query](https://learn.microsoft.com/en-us/windows/win32/wmisdk/invoking-a-synchronous-query)
- [Specifying Access Rights](https://learn.microsoft.com/en-us/windows-hardware/drivers/kernel/access-mask)
