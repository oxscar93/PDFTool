using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
