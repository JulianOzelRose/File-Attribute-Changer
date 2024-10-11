
namespace File_Attribute_Changer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblFilename = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.txtFileSize = new System.Windows.Forms.TextBox();
            this.txtFileLocation = new System.Windows.Forms.TextBox();
            this.txtFileType = new System.Windows.Forms.TextBox();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.lblFileLocation = new System.Windows.Forms.Label();
            this.lblFileType = new System.Windows.Forms.Label();
            this.grpFileAttributes = new System.Windows.Forms.GroupBox();
            this.chkEncrypted = new System.Windows.Forms.CheckBox();
            this.chkCompressed = new System.Windows.Forms.CheckBox();
            this.chkIndexed = new System.Windows.Forms.CheckBox();
            this.chkSystem = new System.Windows.Forms.CheckBox();
            this.chkHidden = new System.Windows.Forms.CheckBox();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.grpDateAttributes = new System.Windows.Forms.GroupBox();
            this.dtpTimeAccessed = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeModified = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeCreated = new System.Windows.Forms.DateTimePicker();
            this.lblDateAccessed = new System.Windows.Forms.Label();
            this.lblDateModified = new System.Windows.Forms.Label();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.dtpDateAccessed = new System.Windows.Forms.DateTimePicker();
            this.dtpDateModified = new System.Windows.Forms.DateTimePicker();
            this.dtpDateCreated = new System.Windows.Forms.DateTimePicker();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tsrToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsddbFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiBrowse = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddbHelp = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiReportBug = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.grpGeneral.SuspendLayout();
            this.grpFileAttributes.SuspendLayout();
            this.grpDateAttributes.SuspendLayout();
            this.tsrToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(244, 35);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(18, 40);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(52, 13);
            this.lblFilename.TabIndex = 5;
            this.lblFilename.Text = "Filename:";
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(76, 37);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(159, 20);
            this.txtFilename.TabIndex = 1;
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.txtFileSize);
            this.grpGeneral.Controls.Add(this.txtFileLocation);
            this.grpGeneral.Controls.Add(this.txtFileType);
            this.grpGeneral.Controls.Add(this.lblFileSize);
            this.grpGeneral.Controls.Add(this.lblFileLocation);
            this.grpGeneral.Controls.Add(this.lblFileType);
            this.grpGeneral.Location = new System.Drawing.Point(12, 65);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(307, 108);
            this.grpGeneral.TabIndex = 2;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // txtFileSize
            // 
            this.txtFileSize.Location = new System.Drawing.Point(96, 74);
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.ReadOnly = true;
            this.txtFileSize.Size = new System.Drawing.Size(196, 20);
            this.txtFileSize.TabIndex = 4;
            // 
            // txtFileLocation
            // 
            this.txtFileLocation.Location = new System.Drawing.Point(96, 46);
            this.txtFileLocation.Name = "txtFileLocation";
            this.txtFileLocation.ReadOnly = true;
            this.txtFileLocation.Size = new System.Drawing.Size(196, 20);
            this.txtFileLocation.TabIndex = 3;
            // 
            // txtFileType
            // 
            this.txtFileType.Location = new System.Drawing.Point(96, 18);
            this.txtFileType.Name = "txtFileType";
            this.txtFileType.ReadOnly = true;
            this.txtFileType.Size = new System.Drawing.Size(196, 20);
            this.txtFileType.TabIndex = 2;
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(12, 77);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(30, 13);
            this.lblFileSize.TabIndex = 2;
            this.lblFileSize.Text = "Size:";
            // 
            // lblFileLocation
            // 
            this.lblFileLocation.AutoSize = true;
            this.lblFileLocation.Location = new System.Drawing.Point(12, 49);
            this.lblFileLocation.Name = "lblFileLocation";
            this.lblFileLocation.Size = new System.Drawing.Size(51, 13);
            this.lblFileLocation.TabIndex = 1;
            this.lblFileLocation.Text = "Location:";
            // 
            // lblFileType
            // 
            this.lblFileType.AutoSize = true;
            this.lblFileType.Location = new System.Drawing.Point(12, 21);
            this.lblFileType.Name = "lblFileType";
            this.lblFileType.Size = new System.Drawing.Size(34, 13);
            this.lblFileType.TabIndex = 0;
            this.lblFileType.Text = "Type:";
            // 
            // grpFileAttributes
            // 
            this.grpFileAttributes.Controls.Add(this.chkEncrypted);
            this.grpFileAttributes.Controls.Add(this.chkCompressed);
            this.grpFileAttributes.Controls.Add(this.chkIndexed);
            this.grpFileAttributes.Controls.Add(this.chkSystem);
            this.grpFileAttributes.Controls.Add(this.chkHidden);
            this.grpFileAttributes.Controls.Add(this.chkReadOnly);
            this.grpFileAttributes.Location = new System.Drawing.Point(12, 179);
            this.grpFileAttributes.Name = "grpFileAttributes";
            this.grpFileAttributes.Size = new System.Drawing.Size(307, 70);
            this.grpFileAttributes.TabIndex = 3;
            this.grpFileAttributes.TabStop = false;
            this.grpFileAttributes.Text = "File Attributes";
            // 
            // chkEncrypted
            // 
            this.chkEncrypted.AutoSize = true;
            this.chkEncrypted.Location = new System.Drawing.Point(125, 42);
            this.chkEncrypted.Name = "chkEncrypted";
            this.chkEncrypted.Size = new System.Drawing.Size(62, 17);
            this.chkEncrypted.TabIndex = 7;
            this.chkEncrypted.Text = "Encrypt";
            this.chkEncrypted.UseVisualStyleBackColor = true;
            this.chkEncrypted.CheckedChanged += new System.EventHandler(this.chkEncrypted_CheckedChanged);
            // 
            // chkCompressed
            // 
            this.chkCompressed.AutoSize = true;
            this.chkCompressed.Location = new System.Drawing.Point(15, 42);
            this.chkCompressed.Name = "chkCompressed";
            this.chkCompressed.Size = new System.Drawing.Size(72, 17);
            this.chkCompressed.TabIndex = 6;
            this.chkCompressed.Text = "Compress";
            this.chkCompressed.UseVisualStyleBackColor = true;
            this.chkCompressed.CheckedChanged += new System.EventHandler(this.chkCompressed_CheckedChanged);
            // 
            // chkIndexed
            // 
            this.chkIndexed.AutoSize = true;
            this.chkIndexed.Enabled = false;
            this.chkIndexed.Location = new System.Drawing.Point(232, 19);
            this.chkIndexed.Name = "chkIndexed";
            this.chkIndexed.Size = new System.Drawing.Size(52, 17);
            this.chkIndexed.TabIndex = 5;
            this.chkIndexed.Text = "Index";
            this.chkIndexed.UseVisualStyleBackColor = true;
            // 
            // chkSystem
            // 
            this.chkSystem.AutoSize = true;
            this.chkSystem.Location = new System.Drawing.Point(232, 42);
            this.chkSystem.Name = "chkSystem";
            this.chkSystem.Size = new System.Drawing.Size(60, 17);
            this.chkSystem.TabIndex = 4;
            this.chkSystem.Text = "System";
            this.chkSystem.UseVisualStyleBackColor = true;
            // 
            // chkHidden
            // 
            this.chkHidden.AutoSize = true;
            this.chkHidden.Location = new System.Drawing.Point(125, 19);
            this.chkHidden.Name = "chkHidden";
            this.chkHidden.Size = new System.Drawing.Size(60, 17);
            this.chkHidden.TabIndex = 3;
            this.chkHidden.Text = "Hidden";
            this.chkHidden.UseVisualStyleBackColor = true;
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Location = new System.Drawing.Point(15, 19);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(74, 17);
            this.chkReadOnly.TabIndex = 2;
            this.chkReadOnly.Text = "Read-only";
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // grpDateAttributes
            // 
            this.grpDateAttributes.Controls.Add(this.dtpTimeAccessed);
            this.grpDateAttributes.Controls.Add(this.dtpTimeModified);
            this.grpDateAttributes.Controls.Add(this.dtpTimeCreated);
            this.grpDateAttributes.Controls.Add(this.lblDateAccessed);
            this.grpDateAttributes.Controls.Add(this.lblDateModified);
            this.grpDateAttributes.Controls.Add(this.lblDateCreated);
            this.grpDateAttributes.Controls.Add(this.dtpDateAccessed);
            this.grpDateAttributes.Controls.Add(this.dtpDateModified);
            this.grpDateAttributes.Controls.Add(this.dtpDateCreated);
            this.grpDateAttributes.Location = new System.Drawing.Point(12, 255);
            this.grpDateAttributes.Name = "grpDateAttributes";
            this.grpDateAttributes.Size = new System.Drawing.Size(307, 131);
            this.grpDateAttributes.TabIndex = 4;
            this.grpDateAttributes.TabStop = false;
            this.grpDateAttributes.Text = "Date Attributes";
            // 
            // dtpTimeAccessed
            // 
            this.dtpTimeAccessed.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeAccessed.Location = new System.Drawing.Point(197, 90);
            this.dtpTimeAccessed.Name = "dtpTimeAccessed";
            this.dtpTimeAccessed.Size = new System.Drawing.Size(95, 20);
            this.dtpTimeAccessed.TabIndex = 8;
            // 
            // dtpTimeModified
            // 
            this.dtpTimeModified.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeModified.Location = new System.Drawing.Point(197, 58);
            this.dtpTimeModified.Name = "dtpTimeModified";
            this.dtpTimeModified.Size = new System.Drawing.Size(95, 20);
            this.dtpTimeModified.TabIndex = 7;
            // 
            // dtpTimeCreated
            // 
            this.dtpTimeCreated.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeCreated.Location = new System.Drawing.Point(197, 27);
            this.dtpTimeCreated.Name = "dtpTimeCreated";
            this.dtpTimeCreated.Size = new System.Drawing.Size(95, 20);
            this.dtpTimeCreated.TabIndex = 6;
            // 
            // lblDateAccessed
            // 
            this.lblDateAccessed.AutoSize = true;
            this.lblDateAccessed.Location = new System.Drawing.Point(8, 92);
            this.lblDateAccessed.Name = "lblDateAccessed";
            this.lblDateAccessed.Size = new System.Drawing.Size(57, 13);
            this.lblDateAccessed.TabIndex = 5;
            this.lblDateAccessed.Text = "Accessed:";
            // 
            // lblDateModified
            // 
            this.lblDateModified.AutoSize = true;
            this.lblDateModified.Location = new System.Drawing.Point(8, 62);
            this.lblDateModified.Name = "lblDateModified";
            this.lblDateModified.Size = new System.Drawing.Size(50, 13);
            this.lblDateModified.TabIndex = 4;
            this.lblDateModified.Text = "Modified:";
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Location = new System.Drawing.Point(8, 31);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(47, 13);
            this.lblDateCreated.TabIndex = 3;
            this.lblDateCreated.Text = "Created:";
            // 
            // dtpDateAccessed
            // 
            this.dtpDateAccessed.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateAccessed.Location = new System.Drawing.Point(96, 90);
            this.dtpDateAccessed.Name = "dtpDateAccessed";
            this.dtpDateAccessed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDateAccessed.Size = new System.Drawing.Size(95, 20);
            this.dtpDateAccessed.TabIndex = 2;
            // 
            // dtpDateModified
            // 
            this.dtpDateModified.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateModified.Location = new System.Drawing.Point(96, 58);
            this.dtpDateModified.Name = "dtpDateModified";
            this.dtpDateModified.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDateModified.Size = new System.Drawing.Size(95, 20);
            this.dtpDateModified.TabIndex = 1;
            // 
            // dtpDateCreated
            // 
            this.dtpDateCreated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateCreated.Location = new System.Drawing.Point(96, 27);
            this.dtpDateCreated.Name = "dtpDateCreated";
            this.dtpDateCreated.Size = new System.Drawing.Size(95, 20);
            this.dtpDateCreated.TabIndex = 0;
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(244, 392);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(163, 392);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(82, 392);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tsrToolStrip
            // 
            this.tsrToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsrToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbFile,
            this.tsddbHelp});
            this.tsrToolStrip.Location = new System.Drawing.Point(0, 0);
            this.tsrToolStrip.Name = "tsrToolStrip";
            this.tsrToolStrip.Size = new System.Drawing.Size(332, 25);
            this.tsrToolStrip.TabIndex = 7;
            this.tsrToolStrip.Text = "toolStrip1";
            // 
            // tsddbFile
            // 
            this.tsddbFile.AutoToolTip = false;
            this.tsddbFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBrowse,
            this.tsmiFileSeparator,
            this.tsmiExit});
            this.tsddbFile.Image = ((System.Drawing.Image)(resources.GetObject("tsddbFile.Image")));
            this.tsddbFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbFile.Name = "tsddbFile";
            this.tsddbFile.ShowDropDownArrow = false;
            this.tsddbFile.Size = new System.Drawing.Size(29, 22);
            this.tsddbFile.Text = "File";
            // 
            // tsmiBrowse
            // 
            this.tsmiBrowse.Name = "tsmiBrowse";
            this.tsmiBrowse.Size = new System.Drawing.Size(180, 22);
            this.tsmiBrowse.Text = "Browse...";
            this.tsmiBrowse.Click += new System.EventHandler(this.tsmiBrowse_Click);
            // 
            // tsmiFileSeparator
            // 
            this.tsmiFileSeparator.Name = "tsmiFileSeparator";
            this.tsmiFileSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(180, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsddbHelp
            // 
            this.tsddbHelp.AutoToolTip = false;
            this.tsddbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReportBug});
            this.tsddbHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsddbHelp.Image")));
            this.tsddbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbHelp.Name = "tsddbHelp";
            this.tsddbHelp.ShowDropDownArrow = false;
            this.tsddbHelp.Size = new System.Drawing.Size(36, 22);
            this.tsddbHelp.Text = "Help";
            // 
            // tsmiReportBug
            // 
            this.tsmiReportBug.Name = "tsmiReportBug";
            this.tsmiReportBug.Size = new System.Drawing.Size(180, 22);
            this.tsmiReportBug.Text = "Report a Bug";
            this.tsmiReportBug.Click += new System.EventHandler(this.tsmiReportBug_Click);
            // 
            // lblSeparator
            // 
            this.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSeparator.Location = new System.Drawing.Point(0, 25);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(332, 2);
            this.lblSeparator.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 424);
            this.Controls.Add(this.lblSeparator);
            this.Controls.Add(this.tsrToolStrip);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.grpDateAttributes);
            this.Controls.Add(this.grpFileAttributes);
            this.Controls.Add(this.grpGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Attribute Changer";
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpFileAttributes.ResumeLayout(false);
            this.grpFileAttributes.PerformLayout();
            this.grpDateAttributes.ResumeLayout(false);
            this.grpDateAttributes.PerformLayout();
            this.tsrToolStrip.ResumeLayout(false);
            this.tsrToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.TextBox txtFileSize;
        private System.Windows.Forms.TextBox txtFileLocation;
        private System.Windows.Forms.TextBox txtFileType;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.Label lblFileLocation;
        private System.Windows.Forms.Label lblFileType;
        private System.Windows.Forms.GroupBox grpFileAttributes;
        private System.Windows.Forms.GroupBox grpDateAttributes;
        private System.Windows.Forms.CheckBox chkHidden;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.Label lblDateAccessed;
        private System.Windows.Forms.Label lblDateModified;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.DateTimePicker dtpDateAccessed;
        private System.Windows.Forms.DateTimePicker dtpDateModified;
        private System.Windows.Forms.DateTimePicker dtpDateCreated;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DateTimePicker dtpTimeAccessed;
        private System.Windows.Forms.DateTimePicker dtpTimeModified;
        private System.Windows.Forms.DateTimePicker dtpTimeCreated;
        private System.Windows.Forms.CheckBox chkSystem;
        private System.Windows.Forms.CheckBox chkIndexed;
        private System.Windows.Forms.CheckBox chkCompressed;
        private System.Windows.Forms.CheckBox chkEncrypted;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.ToolStrip tsrToolStrip;
        private System.Windows.Forms.ToolStripDropDownButton tsddbFile;
        private System.Windows.Forms.ToolStripDropDownButton tsddbHelp;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiReportBug;
        private System.Windows.Forms.ToolStripMenuItem tsmiBrowse;
        private System.Windows.Forms.ToolStripSeparator tsmiFileSeparator;
    }
}

