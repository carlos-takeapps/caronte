using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Caronte;

namespace Caronte.Client
{
    public partial class Form1 : Form
    {
        Caronte.Caronte service;

        public Form1()
        {
            InitializeComponent();
            InitServiceProxy();
            LoadInfo();
        }

        void InitServiceProxy()
        { 
            service =  new Caronte.Caronte();
        }

        void LoadInfo()
        {
            this.txtService.Text = service.Url;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            btnDownload.Enabled = false;

            string result = string.Empty;
            bool fetched = false;

            try
            {
                fetched = service.GetBase64EncodedResource(this.txtURL.Text, out result);
            }
            catch
            {
                MessageBox.Show("Error fetching file");
            }

            if (fetched)
            {
                int nameIdx = this.txtService.Text.LastIndexOf("/") - 1;
                String fileName = this.txtURL.Text.Substring(nameIdx) ;
                
                SaveDocument(fileName, result);
            }

            btnDownload.Enabled = true;
        }

        private void SaveDocument(string name, string content)
        {
            string filePath = string.Empty;
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.FileName = name;

            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                filePath = saveDlg.FileName;
            }
            else
            {
                return;
            }

            byte[] fileContent = Convert.FromBase64String(content);
            System.IO.File.WriteAllBytes(filePath, fileContent);
        }
    }
}