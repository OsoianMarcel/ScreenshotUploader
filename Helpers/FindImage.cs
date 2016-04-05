using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace App.Helpers
{
    public static class FindImage
    {
        // Find image files
        public static List<Models.ImageFile> find(string[] paths)
        {
            List<Models.ImageFile> images = new List<Models.ImageFile>();

            foreach (string path in paths)
            {
                // Check if current path is a file
                if (!File.Exists(path))
                {
                    continue;
                }

                // Get file extension
                string extension = getFileExtension(path);

                // Check if current file is an accepted image
                if (!isExtensionAccepted(extension))
                {
                    continue;
                }

                // Push image to collection
                Models.ImageFile imageFile = new Models.ImageFile();
                imageFile.path = path;
                imageFile.mimeType = MimeType.find(extension);
                images.Add(imageFile);
            }

            return images;
        }

        // Check if image is accepted by extension
        private static bool isExtensionAccepted(string extension)
        {
            return Global.acceptedImageExtensions.Contains(extension);
        }

        // Get file extension (lowercase)
        private static string getFileExtension(string path)
        {
            return Path.GetExtension(path).Replace(".", "").ToLower();
        }
    }
}