using System;

namespace App.Models
{
    public class ImageUpload
    {
        public byte[] bytes { get; set; }
        public string mimeType { get; set; }
        public ImageFile imageFile { get; set; }
    }
}
