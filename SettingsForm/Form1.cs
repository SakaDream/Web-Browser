using System.Windows.Forms;

namespace SettingsForm
{
    public partial class Form1 : Form
    {
        public string homeAddress { get; set; }
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }
    }
}
