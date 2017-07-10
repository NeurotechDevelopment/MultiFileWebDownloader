using DownloadManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFileWebDownloader
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            using (WebFileDownloader downloader = new WebFileDownloader())
            {
                downloader.DownloadFile(new Uri("http://google.com/vasya.pdf"), "here");
            }
        }

        private void btnSelectDownloadFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDestinationFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
