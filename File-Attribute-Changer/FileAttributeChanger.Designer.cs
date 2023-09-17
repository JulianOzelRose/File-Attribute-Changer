
namespace File_Attribute_Changer
{
    partial class FileAttributeChanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileAttributeChanger));
            this.BrowseButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fileSizeTextBox = new System.Windows.Forms.TextBox();
            this.fileLocationTextBox = new System.Windows.Forms.TextBox();
            this.fileTypeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.encryptedCheckBox = new System.Windows.Forms.CheckBox();
            this.compressedCheckbox = new System.Windows.Forms.CheckBox();
            this.indexedCheckbox = new System.Windows.Forms.CheckBox();
            this.systemCheckBox = new System.Windows.Forms.CheckBox();
            this.hiddenCheckBox = new System.Windows.Forms.CheckBox();
            this.readOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.timeAccessedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeModifiedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeCreatedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateAccessedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateModifiedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateCreatedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.FormCancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(220, 19);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.filenameTextBox);
            this.groupBox1.Controls.Add(this.BrowseButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Name:";
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.Location = new System.Drawing.Point(70, 21);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.ReadOnly = true;
            this.filenameTextBox.Size = new System.Drawing.Size(141, 20);
            this.filenameTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fileSizeTextBox);
            this.groupBox2.Controls.Add(this.fileLocationTextBox);
            this.groupBox2.Controls.Add(this.fileTypeTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 108);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General";
            // 
            // fileSizeTextBox
            // 
            this.fileSizeTextBox.Location = new System.Drawing.Point(70, 74);
            this.fileSizeTextBox.Name = "fileSizeTextBox";
            this.fileSizeTextBox.ReadOnly = true;
            this.fileSizeTextBox.Size = new System.Drawing.Size(196, 20);
            this.fileSizeTextBox.TabIndex = 4;
            // 
            // fileLocationTextBox
            // 
            this.fileLocationTextBox.Location = new System.Drawing.Point(70, 46);
            this.fileLocationTextBox.Name = "fileLocationTextBox";
            this.fileLocationTextBox.ReadOnly = true;
            this.fileLocationTextBox.Size = new System.Drawing.Size(196, 20);
            this.fileLocationTextBox.TabIndex = 3;
            // 
            // fileTypeTextBox
            // 
            this.fileTypeTextBox.Location = new System.Drawing.Point(70, 18);
            this.fileTypeTextBox.Name = "fileTypeTextBox";
            this.fileTypeTextBox.ReadOnly = true;
            this.fileTypeTextBox.Size = new System.Drawing.Size(196, 20);
            this.fileTypeTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.encryptedCheckBox);
            this.groupBox3.Controls.Add(this.compressedCheckbox);
            this.groupBox3.Controls.Add(this.indexedCheckbox);
            this.groupBox3.Controls.Add(this.systemCheckBox);
            this.groupBox3.Controls.Add(this.hiddenCheckBox);
            this.groupBox3.Controls.Add(this.readOnlyCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 70);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File Attributes";
            // 
            // encryptedCheckBox
            // 
            this.encryptedCheckBox.AutoSize = true;
            this.encryptedCheckBox.Location = new System.Drawing.Point(125, 42);
            this.encryptedCheckBox.Name = "encryptedCheckBox";
            this.encryptedCheckBox.Size = new System.Drawing.Size(62, 17);
            this.encryptedCheckBox.TabIndex = 7;
            this.encryptedCheckBox.Text = "Encrypt";
            this.encryptedCheckBox.UseVisualStyleBackColor = true;
            this.encryptedCheckBox.CheckedChanged += new System.EventHandler(this.EncryptedCheckBox_CheckedChanged);
            // 
            // compressedCheckbox
            // 
            this.compressedCheckbox.AutoSize = true;
            this.compressedCheckbox.Location = new System.Drawing.Point(15, 42);
            this.compressedCheckbox.Name = "compressedCheckbox";
            this.compressedCheckbox.Size = new System.Drawing.Size(72, 17);
            this.compressedCheckbox.TabIndex = 6;
            this.compressedCheckbox.Text = "Compress";
            this.compressedCheckbox.UseVisualStyleBackColor = true;
            this.compressedCheckbox.CheckedChanged += new System.EventHandler(this.CompressedCheckbox_CheckedChanged);
            // 
            // indexedCheckbox
            // 
            this.indexedCheckbox.AutoSize = true;
            this.indexedCheckbox.Enabled = false;
            this.indexedCheckbox.Location = new System.Drawing.Point(232, 19);
            this.indexedCheckbox.Name = "indexedCheckbox";
            this.indexedCheckbox.Size = new System.Drawing.Size(52, 17);
            this.indexedCheckbox.TabIndex = 5;
            this.indexedCheckbox.Text = "Index";
            this.indexedCheckbox.UseVisualStyleBackColor = true;
            // 
            // systemCheckBox
            // 
            this.systemCheckBox.AutoSize = true;
            this.systemCheckBox.Location = new System.Drawing.Point(232, 42);
            this.systemCheckBox.Name = "systemCheckBox";
            this.systemCheckBox.Size = new System.Drawing.Size(60, 17);
            this.systemCheckBox.TabIndex = 4;
            this.systemCheckBox.Text = "System";
            this.systemCheckBox.UseVisualStyleBackColor = true;
            // 
            // hiddenCheckBox
            // 
            this.hiddenCheckBox.AutoSize = true;
            this.hiddenCheckBox.Location = new System.Drawing.Point(125, 19);
            this.hiddenCheckBox.Name = "hiddenCheckBox";
            this.hiddenCheckBox.Size = new System.Drawing.Size(60, 17);
            this.hiddenCheckBox.TabIndex = 3;
            this.hiddenCheckBox.Text = "Hidden";
            this.hiddenCheckBox.UseVisualStyleBackColor = true;
            // 
            // readOnlyCheckBox
            // 
            this.readOnlyCheckBox.AutoSize = true;
            this.readOnlyCheckBox.Location = new System.Drawing.Point(15, 19);
            this.readOnlyCheckBox.Name = "readOnlyCheckBox";
            this.readOnlyCheckBox.Size = new System.Drawing.Size(74, 17);
            this.readOnlyCheckBox.TabIndex = 2;
            this.readOnlyCheckBox.Text = "Read-only";
            this.readOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.timeAccessedTimePicker);
            this.groupBox4.Controls.Add(this.timeModifiedTimePicker);
            this.groupBox4.Controls.Add(this.timeCreatedTimePicker);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.dateAccessedTimePicker);
            this.groupBox4.Controls.Add(this.dateModifiedTimePicker);
            this.groupBox4.Controls.Add(this.dateCreatedTimePicker);
            this.groupBox4.Location = new System.Drawing.Point(12, 263);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(307, 131);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Date Attributes";
            // 
            // timeAccessedTimePicker
            // 
            this.timeAccessedTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeAccessedTimePicker.Location = new System.Drawing.Point(171, 90);
            this.timeAccessedTimePicker.Name = "timeAccessedTimePicker";
            this.timeAccessedTimePicker.Size = new System.Drawing.Size(95, 20);
            this.timeAccessedTimePicker.TabIndex = 8;
            // 
            // timeModifiedTimePicker
            // 
            this.timeModifiedTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeModifiedTimePicker.Location = new System.Drawing.Point(171, 58);
            this.timeModifiedTimePicker.Name = "timeModifiedTimePicker";
            this.timeModifiedTimePicker.Size = new System.Drawing.Size(95, 20);
            this.timeModifiedTimePicker.TabIndex = 7;
            // 
            // timeCreatedTimePicker
            // 
            this.timeCreatedTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeCreatedTimePicker.Location = new System.Drawing.Point(171, 27);
            this.timeCreatedTimePicker.Name = "timeCreatedTimePicker";
            this.timeCreatedTimePicker.Size = new System.Drawing.Size(95, 20);
            this.timeCreatedTimePicker.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Accessed:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Modified:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Created:";
            // 
            // dateAccessedTimePicker
            // 
            this.dateAccessedTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateAccessedTimePicker.Location = new System.Drawing.Point(70, 90);
            this.dateAccessedTimePicker.Name = "dateAccessedTimePicker";
            this.dateAccessedTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateAccessedTimePicker.Size = new System.Drawing.Size(95, 20);
            this.dateAccessedTimePicker.TabIndex = 2;
            // 
            // dateModifiedTimePicker
            // 
            this.dateModifiedTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateModifiedTimePicker.Location = new System.Drawing.Point(70, 58);
            this.dateModifiedTimePicker.Name = "dateModifiedTimePicker";
            this.dateModifiedTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateModifiedTimePicker.Size = new System.Drawing.Size(95, 20);
            this.dateModifiedTimePicker.TabIndex = 1;
            // 
            // dateCreatedTimePicker
            // 
            this.dateCreatedTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCreatedTimePicker.Location = new System.Drawing.Point(70, 27);
            this.dateCreatedTimePicker.Name = "dateCreatedTimePicker";
            this.dateCreatedTimePicker.Size = new System.Drawing.Size(95, 20);
            this.dateCreatedTimePicker.TabIndex = 0;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(244, 400);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 2;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // FormCancelButton
            // 
            this.FormCancelButton.Location = new System.Drawing.Point(163, 400);
            this.FormCancelButton.Name = "FormCancelButton";
            this.FormCancelButton.Size = new System.Drawing.Size(75, 23);
            this.FormCancelButton.TabIndex = 5;
            this.FormCancelButton.Text = "Cancel";
            this.FormCancelButton.UseVisualStyleBackColor = true;
            this.FormCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(82, 400);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // FileAttributeChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 429);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.FormCancelButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FileAttributeChanger";
            this.Text = "File Attribute Changer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox fileSizeTextBox;
        private System.Windows.Forms.TextBox fileLocationTextBox;
        private System.Windows.Forms.TextBox fileTypeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox hiddenCheckBox;
        private System.Windows.Forms.CheckBox readOnlyCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateAccessedTimePicker;
        private System.Windows.Forms.DateTimePicker dateModifiedTimePicker;
        private System.Windows.Forms.DateTimePicker dateCreatedTimePicker;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button FormCancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.DateTimePicker timeAccessedTimePicker;
        private System.Windows.Forms.DateTimePicker timeModifiedTimePicker;
        private System.Windows.Forms.DateTimePicker timeCreatedTimePicker;
        private System.Windows.Forms.CheckBox systemCheckBox;
        private System.Windows.Forms.CheckBox indexedCheckbox;
        private System.Windows.Forms.CheckBox compressedCheckbox;
        private System.Windows.Forms.CheckBox encryptedCheckBox;
        private System.Windows.Forms.Label label7;
    }
}

