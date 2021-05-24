using CefSharp.WinForms;
using System;
using System.Windows.Forms;

namespace GSBrowserApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void textUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // enter key
                browser.Load(textUrl.Text);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {

        }

        ChromiumWebBrowser browser;
        private void frmMain_Load(object sender, EventArgs e)
        {
            browser = new ChromiumWebBrowser(textUrl.Text);
            browser.Dock = DockStyle.Fill;
            this.pContainer.Controls.Add(browser); // Adds browser to Panel Control
        }
    }
}
