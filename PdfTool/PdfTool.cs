using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfTool
{
    public partial class PDFTool : Form
    {
        private string LastFile { get; set; }
        public PDFTool()
        {
            InitializeComponent();
        }

        private void genetePdfBtn_Click(object sender, EventArgs e)
        {
            var bytes = Base64Util.GetBase64(base64Txt.Text);

            if (bytes == null || bytes.Count() == 0)
            {
                MessageBox.Show("Base 64 invalid", "Error");

                return;
            }

            var sf = ControlFactory.CreatePdfSaveDialog();

            if (sf.ShowDialog() == DialogResult.OK)
            {
                if (!FileUtil.CreateFile(bytes, sf.FileName, FileMode.Create))
                {
                    MessageBox.Show("Error while creating file", "Error");
                }
                else
                {
                    LastFile = FileUtil.GetFileFolderDirectoryFromFullPath(sf.FileName, ".pdf");
                    openContainingBtn.Enabled = true;
                    browser.Navigate(sf.FileName + "#toolbar=0&navpanes=0");
                }                  
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void openContainingBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LastFile))
                 Process.Start(LastFile);
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            var tempDir = Environment.CurrentDirectory + @"\ExportedPDF_Temp.pdf";

            var bytes = Base64Util.GetBase64(base64Txt.Text);

            if (bytes == null || bytes.Count() == 0)
            {
                MessageBox.Show("Base 64 invalid", "Error");
                return;
            }

            if (!FileUtil.CreateFile(bytes, tempDir , FileMode.Create))
            {
                MessageBox.Show("Error while creating file", "Error");
            }
            else
            {
                browser.Navigate(tempDir + "#toolbar=0&navpanes=0");
                previewBtn.Enabled = false;
            }       
        }

        private void PDFTool_Load(object sender, EventArgs e)
        {
            base64Txt.TextChanged += ClearBrowser;
        }

        private void ClearBrowser(object sender, EventArgs e)
        {
            browser.Navigate("about:blank");
            previewBtn.Enabled = true;
            openContainingBtn.Enabled = false;
        }
    }
}
