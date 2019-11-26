using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfTool
{
    public static class FileUtil
    {
        public static bool CreateFile(byte[] bytes, string fileName, FileMode mode)
        {
            try
            {
                FileStream stream =
                new FileStream(fileName, mode);

                System.IO.BinaryWriter writer =
                    new BinaryWriter(stream);

                writer.Write(bytes, 0, bytes.Length);
                writer.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }         
        }

        public static bool Delete(string fileName, int retry = 0)
        {
            try
            {
                File.Delete(fileName);
                return true;
            }
            catch (Exception ex)
            {
                //simple hack retry in case the file is already in use
                if (retry < 1)
                    Delete(fileName, retry++);
                return false;
            }
        }

        public static string GetFileFolderDirectoryFromFullPath(string filename, string extension)
        {
            var splitted = filename.Split('\\');
            var result = string.Empty;

            foreach (var item in splitted)
            {
                if (!item.Contains(extension))
                    result += item + "\\";
            }

            return result;
        }
    }
}
