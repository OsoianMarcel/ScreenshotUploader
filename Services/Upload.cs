using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;
using System.IO;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Script.Serialization;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace App.Service
{
    public class Upload
    {
        public delegate void SuccessCallback(Models.StaticMd.Image image);
        public delegate void ErrorCallback(string error);
        public delegate void CompleteCallback();
        public delegate void ImageCallback(Image image);

        private event SuccessCallback successCallback;
        private event ErrorCallback errorCallback;
        private event CompleteCallback completeCallback;
        private event ImageCallback imageCallback;

        public bool isBusy { get; private set; }

        // Add success callback
        public void onSuccess(SuccessCallback callback)
        {
            this.successCallback += callback;
        }

        // Add error callback
        public void onError(ErrorCallback callback)
        {
            this.errorCallback += callback;
        }

        // Add complete callback
        public void onComplete(CompleteCallback callback)
        {
            this.completeCallback += callback;
        }

        public void onImage(ImageCallback callback)
        {
            this.imageCallback += callback;
        }

        // Upload image by using separate thread
        public void uploadImageAsync(Image image)
        {
            ThreadPool.QueueUserWorkItem(q => this.detectThreadWork(image));
        }

        // Upload image without separate thread
        public void uploadImage(Image image)
        {
            this.detectThreadWork(image);
        }

        // Upload image files by using separate thread
        public void uploadImageFilesAsync(List<Models.ImageFile> imageFiles)
        {
            ThreadPool.QueueUserWorkItem(q => this.detectThreadWork(imageFiles));
        }

        // Upload image files
        public void uploadImageFiles(List<Models.ImageFile> imageFiles)
        {
            this.detectThreadWork(imageFiles);
        }

        // Detect Image
        private void detectThreadWork(Image image)
        {
            this.isBusy = true;

            List<Models.ImageUpload> imageUploads = new List<Models.ImageUpload>();

            Models.ImageUpload imageUpload = new Models.ImageUpload();
            imageUpload.bytes = this.getBytesFromImage(image);
            imageUpload.mimeType = "image/png";

            if (this.imageCallback != null)
            {
                this.imageCallback(image);
            }

            imageUploads.Add(imageUpload);
            this.doThreadWork(imageUploads);
        }

        // Detect ImageFile
        private void detectThreadWork(List<Models.ImageFile> imageFiles)
        {
            this.isBusy = true;

            List<Models.ImageUpload> imageUploads = new List<Models.ImageUpload>();

            foreach (Models.ImageFile imageFile in imageFiles)
            {
                Models.ImageUpload imageUpload = new Models.ImageUpload();
                imageUpload.bytes = this.getBytesFromPath(imageFile.path);
                imageUpload.mimeType = imageFile.mimeType;
                imageUpload.imageFile = imageFile;

                imageUploads.Add(imageUpload);
            }

            this.doThreadWork(imageUploads);
        }


        // Thread work
        private void doThreadWork(object param)
        {
            List<Models.ImageUpload> imageUploads = (List<Models.ImageUpload>)param;

            try
            {
                foreach (Models.ImageUpload imageUpload in imageUploads)
                {
                    if (this.imageCallback != null && imageUpload.imageFile != null)
                    {
                        this.imageCallback(Image.FromFile(imageUpload.imageFile.path));
                    }

                    string bytesMd5 = this.getMD5FromBytes(imageUpload.bytes);
                    Models.StaticMd.Token token = this.getToken(bytesMd5);

                    Models.StaticMd.Image upload = this.uploadImage(token, imageUpload);

                    if (upload.error == "")
                    {
                        if (this.successCallback != null)
                        {
                            this.successCallback(upload);
                        }
                    }
                    else
                    {
                        if (this.errorCallback != null)
                        {
                            this.errorCallback(upload.error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (this.errorCallback != null)
                {
                    this.errorCallback(ex.Message);
                }
            }
            finally
            {
                if (this.completeCallback != null)
                {
                    this.completeCallback();
                }

                this.isBusy = false;
            }
        }

        // Upload image
        private Models.StaticMd.Image uploadImage(Models.StaticMd.Token token, Models.ImageUpload imageUpload)
        {
            this.sleepBeforeUpload(token);

            var request = (HttpWebRequest)WebRequest.Create("https://static.md/api/v2/upload/");
            request.Proxy = null;

            const string boundary = "----B0unDAry";

            string postFields = "--" + boundary + "\n"
                + "Content-Disposition: form-data; name=\"token\"\n\n"
                + token.token + "\n"
                + "--" + boundary + "\n"
                + "Content-Disposition: form-data; name=\"image\"; filename=\"image\"\n"
                + "Content-Type: " + imageUpload.mimeType + "\n\n";

            byte[] postFieldsBytes = Encoding.ASCII.GetBytes(postFields);
            byte[] endBoundaryBytes = Encoding.ASCII.GetBytes("\n--" + boundary + "--");

            request.Method = "POST";
            request.ContentType = "multipart/form-data; boundary=" + boundary;
            request.ContentLength = postFieldsBytes.Length + imageUpload.bytes.Length + endBoundaryBytes.Length;

            request.UserAgent = Config.userAgent;
            request.Accept = "application/json";
            request.Headers.Add("Accept-Language", "en");

            using (var stream = request.GetRequestStream())
            {
                stream.Write(postFieldsBytes, 0, postFieldsBytes.Length);
                stream.Write(imageUpload.bytes, 0, imageUpload.bytes.Length);
                stream.Write(endBoundaryBytes, 0, endBoundaryBytes.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            var jsonResponse = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return parseImage(jsonResponse);
        }

        // Parse image
        private Models.StaticMd.Image parseImage(string json)
        {
            Models.StaticMd.Image image = new JavaScriptSerializer().Deserialize<Models.StaticMd.Image>(json);

            return image;
        }

        // Get token
        private Models.StaticMd.Token getToken(string md5)
        {
            var request = (HttpWebRequest)WebRequest.Create("https://static.md/api/v2/get-token/");
            request.Proxy = null;

            var postData = "md5=" + Uri.EscapeUriString(md5);

            var data = Encoding.ASCII.GetBytes(postData);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            request.UserAgent = Config.userAgent;
            request.Accept = "application/json";
            request.Headers.Add("Accept-Language", "en");

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            var jsonResponse = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return parseToken(jsonResponse);
        }

        // Sleep x seconds before upload
        private void sleepBeforeUpload(Models.StaticMd.Token token)
        {
            Thread.Sleep(token.token_valid_after_seconds * 1000);
        }

        // Parse token
        private Models.StaticMd.Token parseToken(string json)
        {
            Models.StaticMd.Token token = new JavaScriptSerializer().Deserialize<Models.StaticMd.Token>(json);

            return token;
        }

        // Get MD5 from bytes
        private string getMD5FromBytes(byte[] bytes)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] hash = md5.ComputeHash(bytes);

            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash)
            {
                sb.Append(b.ToString("x2").ToLower());
            }

            return sb.ToString();
        }

        // Get bytes from image
        private byte[] getBytesFromImage(Image image)
        {
            byte[] bytes = null;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                bytes = ms.ToArray();
            }

            return bytes;
        }

        // Get bytes form path
        private byte[] getBytesFromPath(string path)
        {
            return System.IO.File.ReadAllBytes(path);
        }
    }
}