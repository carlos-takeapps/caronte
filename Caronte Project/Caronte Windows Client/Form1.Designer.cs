namespace CaronteProject.WinClient
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
            this.btnStartDownload = new System.Windows.Forms.Button();
            this.txtRemoteFile = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnFolderSelect = new System.Windows.Forms.Button();
            this.txtLocalPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStartDownload
            // 
            this.btnStartDownload.Location = new System.Drawing.Point(324, 40);
            this.btnStartDownload.Name = "btnStartDownload";
            this.btnStartDownload.Size = new System.Drawing.Size(88, 23);
            this.btnStartDownload.TabIndex = 0;
            this.btnStartDownload.Text = "Start Download";
            this.btnStartDownload.UseVisualStyleBackColor = true;
            this.btnStartDownload.Click += new System.EventHandler(this.btnStartDownload_Click);
            // 
            // txtRemoteFile
            // 
            this.txtRemoteFile.Location = new System.Drawing.Point(12, 42);
            this.txtRemoteFile.Name = "txtRemoteFile";
            this.txtRemoteFile.Size = new System.Drawing.Size(306, 20);
            this.txtRemoteFile.TabIndex = 1;
            // 
            // btnFolderSelect
            // 
            this.btnFolderSelect.Location = new System.Drawing.Point(382, 10);
            this.btnFolderSelect.Name = "btnFolderSelect";
            this.btnFolderSelect.Size = new System.Drawing.Size(30, 23);
            this.btnFolderSelect.TabIndex = 2;
            this.btnFolderSelect.Text = "...";
            this.btnFolderSelect.UseVisualStyleBackColor = true;
            this.btnFolderSelect.Click += new System.EventHandler(this.btnFolderSelect_Click);
            // 
            // txtLocalPath
            // 
            this.txtLocalPath.Enabled = false;
            this.txtLocalPath.Location = new System.Drawing.Point(12, 12);
            this.txtLocalPath.Name = "txtLocalPath";
            this.txtLocalPath.Size = new System.Drawing.Size(364, 20);
            this.txtLocalPath.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 79);
            this.Controls.Add(this.txtLocalPath);
            this.Controls.Add(this.btnFolderSelect);
            this.Controls.Add(this.txtRemoteFile);
            this.Controls.Add(this.btnStartDownload);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Serial Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartDownload;
        private System.Windows.Forms.TextBox txtRemoteFile;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnFolderSelect;
        private System.Windows.Forms.TextBox txtLocalPath;
    }
}

