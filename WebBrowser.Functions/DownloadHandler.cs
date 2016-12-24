using CefSharp;
using System.Diagnostics;
using System.Windows.Forms;

namespace WebBrowserDemo
{
    public class DownloadHandler : IDownloadHandler
    {
        
        public void OnBeforeDownload(IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {
            Process.Start(Application.StartupPath + "\\fdm\\fdm.exe", downloadItem.Url);
        }

        public void OnDownloadUpdated(IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
        {
            
        }
    }
}