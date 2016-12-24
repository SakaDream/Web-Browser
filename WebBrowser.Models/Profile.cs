using System.Deployment.Application;
using System.Reflection;

namespace WebBrowserDemo
{
    public class Profile
    {
        public string version
        {
            get
            {
                return ApplicationDeployment.IsNetworkDeployed
                       ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
                       : Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }
        public string homePage { get; set; }
        public string TBColor { get; set;}
        public bool AutoCTU { get; set; }
    }
}
