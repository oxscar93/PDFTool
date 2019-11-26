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
        private string TempFilename = Environment.CurrentDirectory + @"\ExportedPDF_Temp.pdf";
        public PDFTool()
        {
            InitializeComponent();
        }

        private void genetePdfBtn_Click(object sender, EventArgs e)
        {
            var bytes = ConvertBase64();

            if (bytes == null) return;

            var sf = ControlFactory.CreatePdfSaveDialog();

            if (sf.ShowDialog() == DialogResult.OK)
            {
                if (CreateFile(bytes, sf.FileName))
                {
                    LastFile = FileUtil.GetFileFolderDirectoryFromFullPath(sf.FileName, ".pdf");
                    openContainingBtn.Enabled = true;
                    OpenPdf(sf.FileName);
                }              
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            browser.Dispose();
            FileUtil.Delete(TempFilename);
            Environment.Exit(0);
        }

        private void openContainingBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LastFile))
                 Process.Start(LastFile);
        }

        private void previewtBtn_Click(object sender, EventArgs e)
        {
            var bytes = ConvertBase64();

            if (bytes == null) return;

            if (CreateFile(bytes, TempFilename))
            {
                OpenPdf(TempFilename);
                previewBtn.Enabled = false;
            }   
        }

        private void PDFTool_Load(object sender, EventArgs e)
        {
            base64Txt.TextChanged += ClearBrowserEvent;
        }

        private void ClearBrowserEvent(object sender, EventArgs e)
        {
            ClearBrowser();
        }

        private void ClearBrowser()
        {
            browser.Navigate("about:blank");
            previewBtn.Enabled = true;
            openContainingBtn.Enabled = false;
        }

        private void OpenPdf(string filename)
        {
            browser.Navigate(filename + "#toolbar=0&navpanes=0");
        }

        private byte[] ConvertBase64()
        {
            var bytes = Base64Util.GetBase64(base64Txt.Text);

            if (bytes == null || bytes.Count() == 0)
            {
                MessageBox.Show("Base 64 invalid", "Error");
                return null;
            }

            return bytes;
        }

        private bool CreateFile(byte[] bytes, string filename)
        {
            if (!FileUtil.CreateFile(bytes, filename, FileMode.Create))
            {
                MessageBox.Show("Error while creating file", "Error");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
