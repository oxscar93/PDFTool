using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfTool
{
    public static class Base64Util
    {
        public static byte[] GetBase64(string base64Txt)
        {
            try
            {
                return Convert.FromBase64String(base64Txt);
            }
            catch
            {
                return null;
            }
        }
    }
}
