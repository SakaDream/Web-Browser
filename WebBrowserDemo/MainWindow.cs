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

        public MainWindow()
        {

        }
    }
}
