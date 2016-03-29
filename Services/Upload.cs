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

namespace App.Service
{
	public class Upload
	{
		public delegate void SuccessCallback(Model.Image image);
		public delegate void ErrorCallback(string error);
		public delegate void CompleteCallback();
		
		private event SuccessCallback successCallback;
        private event ErrorCallback errorCallback;
        private event CompleteCallback completeCallback;
		
        // Constructor
		public Upload()
		{
			
		}
		
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
		
		// Request by using separate thread
        public void doRequestAsync(Image image)
        {
        	ThreadPool.QueueUserWorkItem(new WaitCallback(this.doThreadWork), image);
		}
        
        // Request without separate thread
        public void doRequest(Image image)
        {
        	this.doThreadWork(image);
        }
        
        // Thread work
        private void doThreadWork(object param)
        {
        	Image image = (Image)param;
        	
        	try
			{
        		byte[] imageBytes = this.getBytesFromImage(image);
        		string imageMD5 = this.getMD5FromBytes(imageBytes);
    
        		Model.Token token = this.getToken(imageMD5);
        		
        		Model.Image upload = this.uploadImage(imageBytes, token);
        		if (upload.error == "") {
        			if (this.successCallback != null) {
        				this.successCallback(upload);
					}
        		} else {
        			if (this.errorCallback != null) {
	        			this.errorCallback(upload.error);
					}
        		}
        		
				
        	} catch (Exception ex) {
	        	if (this.errorCallback != null) {
        			this.errorCallback(ex.Message);
				}
        	}
        	finally {
        		if (this.completeCallback != null) {
        			this.completeCallback();
				}
        	}
        }
        
        // Upload image
        private Model.Image uploadImage(byte[] bytes, Model.Token token)
        {
        	this.sleepBeforeUpload(token);
       
        	var request = (HttpWebRequest)WebRequest.Create("https://static.md/api/v2/upload/");
        	request.Proxy = null;
			
        	const string boundary = "----B0unDAry";

        	string postFields = "--" + boundary + "\n"
        		+ "Content-Disposition: form-data; name=\"token\"\n\n"
        		+ token.token + "\n"
        		+ "--" + boundary + "\n"
        		+ "Content-Disposition: form-data; name=\"image\"; filename=\"image.png\"\n"
        		+ "Content-Type: image/png\n\n";
        	
        	byte[] postFieldsBytes = Encoding.ASCII.GetBytes(postFields);
        	byte[] endBoundaryBytes = Encoding.ASCII.GetBytes("\n--" + boundary + "--");
        	
			request.Method = "POST";
			request.ContentType = "multipart/form-data; boundary=" + boundary;
			request.ContentLength = postFieldsBytes.Length + bytes.Length + endBoundaryBytes.Length;
	
			request.UserAgent = Helper.Global.userAgent;
			request.Accept = "application/json";
			request.Headers.Add("Accept-Language", "en");
			
			using (var stream = request.GetRequestStream()) {
			    stream.Write(postFieldsBytes, 0, postFieldsBytes.Length);
			    stream.Write(bytes, 0, bytes.Length);
			    stream.Write(endBoundaryBytes, 0, endBoundaryBytes.Length);
			}
			
			var response = (HttpWebResponse)request.GetResponse();
			
			var jsonResponse = new StreamReader(response.GetResponseStream()).ReadToEnd();
			
			return parseImage(jsonResponse);
        }
        
        // Parse image
        private Model.Image parseImage(string json)
		{
        	Model.Image image = new JavaScriptSerializer().Deserialize<Model.Image>(json);
			
			return image;
        }
        
        // Get token
		private Model.Token getToken(string md5)
		{
			var request = (HttpWebRequest)WebRequest.Create("https://static.md/api/v2/get-token/");
			request.Proxy = null;
			
			var postData = "md5=" + Uri.EscapeUriString(md5);
		    
		    var data = Encoding.ASCII.GetBytes(postData);
			request.Method = "POST";
			request.ContentType = "application/x-www-form-urlencoded";
			request.ContentLength = data.Length;
	
			request.UserAgent = Helper.Global.userAgent;
            request.Accept = "application/json";
            request.Headers.Add("Accept-Language", "en");
			
			using (var stream = request.GetRequestStream()) {
			    stream.Write(data, 0, data.Length);
			}
			
			var response = (HttpWebResponse)request.GetResponse();
			
			var jsonResponse = new StreamReader(response.GetResponseStream()).ReadToEnd();
			
			return parseToken(jsonResponse);
		}
		
		// Sleep x seconds before upload
		private void sleepBeforeUpload(Model.Token token)
		{
			Thread.Sleep(token.token_valid_after_seconds * 1000);
		}
		
		// Parse token
		private Model.Token parseToken(string json)
        {
			Model.Token token = new JavaScriptSerializer().Deserialize<Model.Token>(json);
			
			return token;
		}
		
		// Get MD5 from bytes
		private string getMD5FromBytes(byte[] bytes)
		{
			MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
			byte[] hash = md5.ComputeHash(bytes);
			
			StringBuilder sb = new StringBuilder();
			foreach (byte b in hash) {
			   sb.Append(b.ToString("x2").ToLower());
			}
			
			return sb.ToString();
		}
		
		// Get bytes from image
		private byte[] getBytesFromImage(Image image)
		{
			byte[] bytes = null;
			using (MemoryStream ms = new MemoryStream()) {
			    image.Save(ms, ImageFormat.Png);
				bytes = ms.ToArray();
			}
			
			return bytes;
		}
	}
}
