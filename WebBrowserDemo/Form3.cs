using System.Deployment.Application;
using System.Reflection;
using System.Windows.Forms;

namespace WebBrowserDemo
{
    public partial class Form3 : Form
    {
        public string CurrentVersion
        {
            get
            {
                return ApplicationDeployment.IsNetworkDeployed
                       ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
                       : Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public Form3()
        {
            InitializeComponent();
            CenterToScreen();
            MaximizeBox = false;
            MinimizeBox = false;
            lblVersion.Text = "Version: " + CurrentVersion;
            ShowInTaskbar = false;
        }

        private void btnWN_Click(object sender, System.EventArgs e)
        {
            Form4 WhatsNewForm = new Form4();
            WhatsNewForm.ShowDialog(this);
        }
    }
}
