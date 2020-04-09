namespace Caronte.Client
{
    partial class Form1
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
            this.txtService = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblService = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(12, 25);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(326, 20);
            this.txtService.TabIndex = 0;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(264, 95);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(12, 9);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(46, 13);
            this.lblService.TabIndex = 2;
            this.lblService.Text = "Service:";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(12, 53);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(35, 13);
            this.lblURL.TabIndex = 4;
            this.lblURL.Text = "label2";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(12, 69);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(326, 20);
            this.txtURL.TabIndex = 3;
            this.txtURL.Text = "http://i1.codeplex.com/Images/v15896/logo-home.png";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 127);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtURL;
    }
}

