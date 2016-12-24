﻿using System.Windows.Forms;

namespace WebBrowserDemo
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            CenterToScreen();
            MaximizeBox = false;
            MinimizeBox = false;
            using(System.Net.WebClient client = new System.Net.WebClient())
            {
                txtWN.Text = client.DownloadString("http://sakadream.hol.es/software/web-browser/changelog");
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Dispose();
        }
    }
}
