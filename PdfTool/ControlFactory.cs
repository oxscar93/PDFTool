using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfTool
{
    public static class ControlFactory
    {
        public static SaveFileDialog CreatePdfSaveDialog() {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Pdf files (*.pdf)|*.pdf";
            sf.FilterIndex = 2;
            sf.RestoreDirectory = true;

            return sf;
        }
    }
}
