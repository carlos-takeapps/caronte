using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CaronteProject.WinClient
{
    public partial class MainForm : Form
    {
        string base64;
        string localPath;
        string remotePath;
        string fileName;

        public MainForm()
        {
            InitializeComponent();
            backgroundWorker1.DoWork += new DoWorkEventHandler(GetFile);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(GotFile);
        }

        void GotFile(object sender, RunWorkerCompletedEventArgs e)
        {
            byte[] base64Bytes = Convert.FromBase64String(this.base64);

            FileStream stream = new FileStream(string.Format(@"{0}\{1}", localPath, fileName), FileMode.Create);
            stream.Write(base64Bytes, 0, base64Bytes.Length);
            stream.Close();

            MessageBox.Show("Done !");
            
            ToggleControl();
        }

        private void GetFile(object sender, DoWorkEventArgs e)
        {
            CaronteService.Caronte service = new CaronteService.Caronte();
            this.base64 = service.GetBase64StringFromResource(this.remotePath);
        }

        private void ToggleControl()
        {
            this.txtRemoteFile.Enabled = !this.txtRemoteFile.Enabled;
            this.btnFolderSelect.Enabled = !this.btnFolderSelect.Enabled;
            this.btnStartDownload.Enabled = !this.btnStartDownload.Enabled;
        }

        private void btnStartDownload_Click(object sender, EventArgs e)
        {
            if (this.txtRemoteFile.Text == string.Empty || this.txtLocalPath.Text == string.Empty)
            {
                return;
            }
            this.remotePath = txtRemoteFile.Text;
            fileName = remotePath.Substring(remotePath.LastIndexOf(@"/")+1);

            ToggleControl();

            this.backgroundWorker1.RunWorkerAsync();
        }

        private void btnFolderSelect_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                localPath = folderBrowserDialog1.SelectedPath;
                txtLocalPath.Text = localPath;
            }
        }
    }
}