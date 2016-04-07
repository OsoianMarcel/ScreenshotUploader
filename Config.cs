using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App
{
    class Config
    {
        // User-Agent
        public static readonly string userAgent = "ImageUploader/1.0 (By OMD)";

        // Accepted image extensions
        public static readonly string[] acceptedImageExtensions = {
            "jpg", "jpeg", "jpe", "png", "gif", "ico"
        };
    }
}
