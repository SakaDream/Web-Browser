using CefSharp;
using CefSharp.WinForms.Internals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;

namespace WebBrowserDemo
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    public partial class MainWindow : Form
    {
        GlobalKeyboardHook gHook = new GlobalKeyboardHook();
        Settings Settings;
        JSON json = new JSON();
        BindingList<KeyValuePair<string, string>> items = new BindingList<KeyValuePair<string, string>>();
        int versionStatus { get; set; }
        const int FAIL_TO_UPDATE = -1;
        const int UP_TO_DATE = 0;
        const int OUT_OF_DATE = 1;
        public string updateStatus { get; set; }
        string htmlDoc = "", domain;
        Downloader downloader = new Downloader();
        int updateSize, time = 4;
        bool flag = true;
        CefSharp.WinForms.ChromiumWebBrowser wB;
        Label lblStatus;

        public MainWindow()
        {
            json.readJSON();
            InitializeComponent();
            tc.SizeMode = TabSizeMode.Fixed;
            btnCT.Enabled = false;
            Cef.Initialize(new CefSettings());
            newTab();
            wB = getCurrentWB();
            lblStatus = getCurrentLblStatus();
            CenterToScreen();
            gHook.KeyDown += new KeyEventHandler(gHook_KeyDown);
            foreach(Keys key in Enum.GetValues(typeof(Keys)))
            {
                gHook.HookedKeys.Add(key);
            }
            gHook.hook();
            ToolBar.BackColor = SystemColors.ActiveCaption;
            WindowState = FormWindowState.Maximized;
            ToolBar.BackColor = ColorTranslator.FromHtml(json.profile.TBColor);
            if (json.profile.AutoCTU)
            {
                timer.Start();
            }
        }

        private void newTab()
        {
            TabPage tp = new TabPage();
            tp.SuspendLayout();
            tp.Location = new System.Drawing.Point(4, 22);
            tp.Padding = new System.Windows.Forms.Padding(3);
            tp.Size = new System.Drawing.Size(1256, 683);
            tp.UseVisualStyleBackColor = true;
            tp.ResumeLayout(false);
            tp.PerformLayout();
            
            NetworkChange.NetworkAddressChanged += new NetworkAddressChangedEventHandler(NetworkChange_NetworkAddressChanged);
            CefSharp.WinForms.ChromiumWebBrowser wB = new CefSharp.WinForms.ChromiumWebBrowser(json.profile.homePage);
            wB.Dock = DockStyle.Fill;
            wB.Location = new Point(0, 0);
            wB.TabIndex = 7;
            wB.LoadingStateChanged += new EventHandler<LoadingStateChangedEventArgs>(this.wB_LoadingStateChanged);
            wB.TitleChanged += new EventHandler<TitleChangedEventArgs>(this.wB_TitleChanged);
            wB.AddressChanged += new EventHandler<AddressChangedEventArgs>(this.wB_AddressChanged);
            wB.StatusMessage += new EventHandler<StatusMessageEventArgs>(this.wB_StatusMessage);
            wB.PreviewKeyDown += new PreviewKeyDownEventHandler(this.wB_PreviewKeyDown);
            wB.DownloadHandler = new DownloadHandler();

            Label lblStatus = new Label();
            lblStatus.Dock = DockStyle.Bottom;

            tp.Controls.Add(wB);
            tp.Controls.Add(lblStatus);
            tc.TabPages.Add(tp);
            tc.SelectedTab = tp;
            if(tc.TabCount == 1)
            {
                tc.ItemSize = new Size(0, 1);
            }
            else
            {
                tc.ItemSize = new Size((tc.Width - 3) / tc.TabCount, 0);
            }
        }

        private CefSharp.WinForms.ChromiumWebBrowser getCurrentWB()
        {
            CefSharp.WinForms.ChromiumWebBrowser wB = null;
            TabPage tp = tc.SelectedTab;
            if (tp != null)
            {
                wB = tp.Controls[0] as CefSharp.WinForms.ChromiumWebBrowser;
            }
            return wB;
        }

        private Label getCurrentLblStatus()
        {
            Label lblStatus = null;
            TabPage tp = tc.SelectedTab;
            if (tp != null)
            {
                lblStatus = tp.Controls[1] as Label;
            }
            return lblStatus;
        }

        private void NetworkChange_NetworkAddressChanged(object sender, EventArgs e)
        {
            if(urlExist("http://www.google.com") & flag)
            {
                browse(txtA.Text);
                flag = false;
            }
        }

        private bool urlExist(string url)
        {
            try
            {
                if (!url.Contains("://"))
                {
                    url = "http://" + url;
                }
                using(var client = new WebClient())
                {
                    using(var stream = client.OpenRead(url))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        private void browse(string add)
        {
            if (urlExist(add))
            {
                wB.Load(add);
            }
            else
            {
                flag = true;
                wB.LoadHtml(Properties.Resources.no_internet_connection, "file://no-internet-connection.html");
                txtA.Text = add;
            }
        }

        public void CheckToUpdate()
        {
            if (!urlExist("http://sakadream.hol.es"))
            {
                if (!urlExist("http://sakadream.comlu.com"))
                {
                    updateStatus = "Cannot connect to server, check your Internet connection and try again";
                    return;
                }
                else domain = "http://sakadream.comlu.com";
            }
            else domain = "http://sakadream.hol.es";
            updateStatus = "Connecting to server...";
            WebClient client = new WebClient();
            htmlDoc = client.DownloadString(domain + "/software/web-browser/version");
            json.readJSON();
            if (json.profile.version.Equals(htmlDoc))
            {
                versionStatus = UP_TO_DATE;
                updateStatus = "It is lastest version!";
            }
            else
            {
                versionStatus = OUT_OF_DATE;
                updateStatus = "New version available! Downloading...";
                bwDownloading.RunWorkerAsync();
            }
        }

        public void Updating()
        {
            FileInfo fi = new FileInfo("Update.7z");
            if(versionStatus == OUT_OF_DATE)
            {
                if(fi.Length == updateSize)
                {
                    var psi = new ProcessStartInfo("cmd.exe", "/c update.bat");
                    psi.CreateNoWindow = true;
                    psi.UseShellExecute = false;
                    psi.RedirectStandardError = true;
                    psi.RedirectStandardOutput = true;
                    var process = Process.Start(psi);
                    process.WaitForExit();
                }
            }
        }

        private void gHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.ContainsFocus)
            {
                if (e.KeyCode.Equals(Keys.F5))
                { 
                    new Thread(() =>
                    {
                        // execute this on the gui thread. (winforms)
                        this.Invoke(new Action(delegate
                        {
                            browse(txtA.Text);
                        }));

                    }).Start();
                }
            }
        }

        private void wB_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            if (wB.IsLoading)
            {
                wB.InvokeOnUiThreadIfRequired(() => btnBack.Enabled = wB.CanGoBack);
                wB.InvokeOnUiThreadIfRequired(() => btnForward.Enabled = wB.CanGoForward);
            }
        }

        private void wB_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            CefSharp.WinForms.ChromiumWebBrowser wB = sender as CefSharp.WinForms.ChromiumWebBrowser;
            if(wB != null)
            {
                wB.InvokeOnUiThreadIfRequired(() => tc.SelectedTab.Text = e.Title);
            }
        }

        private void wB_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            CefSharp.WinForms.ChromiumWebBrowser wB = sender as CefSharp.WinForms.ChromiumWebBrowser;
            if(wB != null)
            {
                if (e.Address != "file://no-internet-connection.html/")
                {
                    wB.InvokeOnUiThreadIfRequired(() => txtA.Text = e.Address);
                }
            }
        }

        private void wB_StatusMessage(object sender, StatusMessageEventArgs e)
        {
            CefSharp.WinForms.ChromiumWebBrowser wB = sender as CefSharp.WinForms.ChromiumWebBrowser;
            if(wB != null)
            {
                wB.InvokeOnUiThreadIfRequired(() => lblStatus.Text = e.Value);
            }
        }

        private void wB_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                browse(txtA.Text);
            }
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtA.Text.Contains(".") && !txtA.Text.Contains(" "))
                {
                    btnBack.Enabled = wB.CanGoBack;
                    btnForward.Enabled = wB.CanGoForward;
                    browse(txtA.Text);
                    e.Handled = true;
                    ActiveControl = wB;
                }
                else
                {
                    browse("https://www.google.com.vn/#q=" + txtA.Text);
                    e.Handled = true;
                    ActiveControl = wB;
                }
            }
        }
        
        private void btnR_Click(object sender, EventArgs e)
        {
            browse(txtA.Text);
            ActiveControl = wB;
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            Settings = new Settings();
            Settings.MinimizeBox = false;
            Settings.MaximizeBox = false;
            Settings.panTBColor.BackColor = ToolBar.BackColor;
            Settings.lblUS.Text = updateStatus;
            Settings.btnCTU.Enabled = (versionStatus == UP_TO_DATE | versionStatus == FAIL_TO_UPDATE) ? true : false;
            Settings.btnChange.Click += BtnChange_Click;
            Settings.btnCTU.Click += BtnCTU_Click;
            Settings.btnAbout.Click += BtnAbout_Click;
            Settings.btnOK.Click += BtnOK_Click;
            Settings.txtInput.Text = json.profile.homePage;
            Settings.cBAutoCTU.Checked = json.profile.AutoCTU;
            Settings.ShowDialog(this);
        }

        private void BtnCTU_Click(object sender, EventArgs e)
        {
            if (!urlExist("http://sakadream.hol.es"))
            {
                if (!urlExist("http://sakadream.comlu.com"))
                {
                    Settings.lblUS.Text = "Cannot connect to server, check your Internet connection and try again";
                    return;
                }
                else domain = "http://sakadream.comlu.com";
            }
            else domain = "http://sakadream.hol.es";
            Settings.lblUS.Text = "Connecting to server...";
            WebClient client = new WebClient();
            htmlDoc = client.DownloadString(domain + "/software/web-browser/version");
            json.readJSON();
            if (json.profile.version.Equals(htmlDoc))
            {
                versionStatus = UP_TO_DATE;
                Settings.lblUS.Text = "It is lastest version!";
            }
            else
            {
                versionStatus = OUT_OF_DATE;
                Settings.lblUS.Text = "New version available! Downloading...";
                bwDownloading.RunWorkerAsync();
                Settings.lblUS.Text = updateStatus;
            }
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog(this);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (Settings.txtInput.Text.Equals(""))
            {
                MessageBox.Show("Please input home address", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                json.profile.homePage = Settings.txtInput.Text;
                Color color = Settings.panTBColor.BackColor;
                json.profile.TBColor = "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
                json.profile.AutoCTU = (Settings.cBAutoCTU.Checked) ? true : false;
                json.writeJSON();
                json.readJSON();
                ToolBar.BackColor = ColorTranslator.FromHtml(json.profile.TBColor);
                ActiveControl = wB;
                Settings.Dispose();
            }
        }
        
        private void BtnChange_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            Settings.panTBColor.BackColor = cd.Color;
        }
        private void btnH_Click(object sender, EventArgs e)
        {
            browse(json.profile.homePage);
            ActiveControl = wB;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            wB.Back();
            ActiveControl = wB;
            btnBack.Enabled = wB.CanGoBack;
            btnForward.Enabled = wB.CanGoForward;
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            wB.Forward();
            ActiveControl = wB;
            btnBack.Enabled = wB.CanGoBack;
            btnForward.Enabled = wB.CanGoForward;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            gHook.unhook();
            Cef.Shutdown();
            Updating();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();

            tooltip.AutoPopDelay = 5000;
            tooltip.InitialDelay = 1000;
            tooltip.ReshowDelay = 500;
            tooltip.ShowAlways = true;

            tooltip.SetToolTip(btnBack, "Click to Go Back");
            tooltip.SetToolTip(btnForward, "Click to Go Forward");
            tooltip.SetToolTip(btnH, "Click to go Homepage");
            tooltip.SetToolTip(btnR, "Click to Reload page");
            tooltip.SetToolTip(btnNT, "Click to create a new tab");
            tooltip.SetToolTip(btnCT, "Click to close current tab");
            tooltip.SetToolTip(btnS, "Click to go Settings");
        }

        private void btnNT_Click(object sender, EventArgs e)
        {
            newTab();
            wB = getCurrentWB();
            lblStatus = getCurrentLblStatus();
            browse(json.profile.homePage);
        }

        private void tc_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCT.Enabled = (tc.TabCount > 1) ? true : false;
            tc.ItemSize = (tc.TabCount > 1) ? new Size(0, 1) : new Size((tc.Width - 3) / tc.TabCount, 0);
            wB = getCurrentWB();
            lblStatus = getCurrentLblStatus();
            txtA.Text = wB.Address;
            btnBack.Enabled = wB.CanGoBack;
            btnForward.Enabled = wB.CanGoForward;
        }

        private void btnCT_Click(object sender, EventArgs e)
        {
            tc.TabPages.Remove(tc.SelectedTab);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time--;
            if(time == 0)
            {
                CheckToUpdate();
                timer.Stop();
            }
        }

        private void bwDownloading_DoWork(object sender, DoWorkEventArgs e)
        {
            string url = domain + "/software/web-browser/" + htmlDoc + "/Update.7z";
            updateSize = downloader.getFileSize(url);
            downloader.downloadFile(url);
            FileInfo fi = new FileInfo("Update.7z");
            if(fi.Length != updateSize)
            {
                if(Settings != null)
                {
                    Settings.btnCTU.Enabled = true;
                }
                versionStatus = FAIL_TO_UPDATE;
                updateStatus = "Failed to download update, check your Internet connection and try again";
            }
            updateStatus = "Download complete! You can exit program to update";
        }
    }
}
