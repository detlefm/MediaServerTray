using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MediaServerTray {
    public class MS_Service {

        public string Server { get; set; } = "localhost";
        public string Port { get; set; } = "8089";
        public string User { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;


        public string MS_Url(string apiCall) {
            // http://localhost:8089/api/status2.html
            if (string.IsNullOrEmpty(User))
                return $"http://{Server}:{Port}/api/{apiCall}";
            else
                return $"http://{User.Replace(" ","%20")}:{Password.Replace(" ","%20")}@{Server}:{Port}/api/{apiCall}";
        }

        private async Task<byte[]> GetBytesAsync(string url) {
            var request = (HttpWebRequest)WebRequest.Create(url);
            using (var response = await request.GetResponseAsync())
            using (var content = new MemoryStream())
            using (var responseStream = response.GetResponseStream()) {
                await responseStream.CopyToAsync(content);
                return content.ToArray();
            }
        }

        public async Task<string> GetStringAsync(string url) {
            var bytes = await GetBytesAsync(url);
            return Encoding.UTF8.GetString(bytes, 0, bytes.Length);
        }
    }
}
