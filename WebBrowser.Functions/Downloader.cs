using System.Net;

namespace WebBrowserDemo
{
    public class Downloader
    {
        public int getFileSize(string url)
        {
            int fileSize = 0;
            WebRequest request = HttpWebRequest.Create(url);
            request.Method = "HEAD";
            using (WebResponse response = request.GetResponse())
            {
                int ContentLength;
                if(int.TryParse(response.Headers.Get("Content-Length"), out ContentLength))
                {
                    fileSize = ContentLength;
                }
            }
            return fileSize;
        }

        public void downloadFile(string url)
        {
            string fileName = url.Substring(url.LastIndexOf("/") + 1);
            WebClient client = new WebClient();
            client.DownloadFile(url, fileName);
        }

        public void downloadFile(string url, string targetFilePath)
        {
            WebClient client = new WebClient();
            client.DownloadFile(url, targetFilePath);
        }
    }
}
