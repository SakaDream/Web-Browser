using System.Windows.Forms;

namespace WebBrowserDemo
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            CenterToScreen();
            ShowInTaskbar = false;
        }
    }
}
