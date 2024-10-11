namespace File_Attribute_Changer
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblProgramTitle = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.llbGitHub = new System.Windows.Forms.LinkLabel();
            this.lblMore = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = global::File_Attribute_Changer.Properties.Resources.File_Attribute_Changer_Icon_Large;
            this.picLogo.Location = new System.Drawing.Point(81, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(128, 128);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblProgramTitle
            // 
            this.lblProgramTitle.AutoSize = true;
            this.lblProgramTitle.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblProgramTitle.Location = new System.Drawing.Point(34, 151);
            this.lblProgramTitle.Name = "lblProgramTitle";
            this.lblProgramTitle.Size = new System.Drawing.Size(224, 29);
            this.lblProgramTitle.TabIndex = 24;
            this.lblProgramTitle.Text = "File Attribute Changer";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(106, 317);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(81, 25);
            this.btnOK.TabIndex = 26;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.llbGitHub);
            this.grpInfo.Controls.Add(this.lblMore);
            this.grpInfo.Controls.Add(this.lblAuthorName);
            this.grpInfo.Controls.Add(this.lblAuthor);
            this.grpInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpInfo.Location = new System.Drawing.Point(13, 185);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(266, 121);
            this.grpInfo.TabIndex = 27;
            this.grpInfo.TabStop = false;
            // 
            // llbGitHub
            // 
            this.llbGitHub.AutoSize = true;
            this.llbGitHub.Location = new System.Drawing.Point(211, 90);
            this.llbGitHub.Name = "llbGitHub";
            this.llbGitHub.Size = new System.Drawing.Size(40, 13);
            this.llbGitHub.TabIndex = 5;
            this.llbGitHub.TabStop = true;
            this.llbGitHub.Text = "GitHub";
            this.llbGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbGitHub_LinkClicked);
            this.llbGitHub.MouseHover += new System.EventHandler(this.llbGitHub_MouseHover);
            // 
            // lblMore
            // 
            this.lblMore.AutoSize = true;
            this.lblMore.Location = new System.Drawing.Point(15, 90);
            this.lblMore.Name = "lblMore";
            this.lblMore.Size = new System.Drawing.Size(34, 13);
            this.lblMore.TabIndex = 4;
            this.lblMore.Text = "More:";
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Location = new System.Drawing.Point(165, 24);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(86, 13);
            this.lblAuthorName.TabIndex = 3;
            this.lblAuthorName.Text = "Julian Ozel Rose";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(15, 24);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblAuthor.TabIndex = 0;
            this.lblAuthor.Text = "Author:";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 355);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblProgramTitle);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblProgramTitle;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.LinkLabel llbGitHub;
        private System.Windows.Forms.Label lblMore;
    }
}