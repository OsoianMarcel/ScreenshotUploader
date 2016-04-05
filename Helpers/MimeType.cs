using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Helpers
{
    public static class MimeType
    {
        // Accepted mime types
        private static readonly Dictionary<string, string> MIMETypes = new Dictionary<string, string>
        {
            {"jpe", "image/jpeg"},
            {"jpeg", "image/jpeg"},
            {"jpg", "image/jpeg"},
            {"png", "image/png"},
            {"gif", "image/gif"},
            {"ico", "image/x-icon"}
        };

        // Find mime type by extension
        public static string find(string extension, string def = "application/octet-stream")
        {
            if (MIMETypes.ContainsKey(extension))
            {
                return MIMETypes[extension];
            }

            return def;
        }
    }
}
