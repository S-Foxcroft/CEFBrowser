using CefSharp;
using CefSharp.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Browser
{
    public partial class Form1 : Form
    {
        ChromiumWebBrowser browser;
        string address;
        bool addUpdate = false;
        public Form1()
        {
            InitializeComponent();
            //Initialize the browser & settings
            CefSettings config = new CefSettings
            {
                UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 10.0; en) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/72.0.3626.109", //temp UA prior to calculation.
                IgnoreCertificateErrors = true
            };
            Cef.Initialize(config);
            menuStrip.Renderer = new MenuRenderer();
            UserSettings.Load();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load homepage, TODO: Allow the user to set a page as home and load that.
            browser = new ChromiumWebBrowser(UserSettings.Home);
            browserContainer.Controls.Add(browser);
            browser.AddressChanged += Browser_AddressChanged;
        }

        private void Browser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            address = e.Address;
            addUpdate = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            UserSettings.Save();
            Application.Exit();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = btnClose.Parent.BackColor;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuStrip.Show(btnMenu, 0, 32);
        }

        private void btnMenu_MouseEnter(object sender, EventArgs e)
        {
            btnMenu.BackColor = Color.DarkSlateGray;
        }

        private void btnMenu_MouseLeave(object sender, EventArgs e)
        {
            btnMenu.BackColor = btnMenu.Parent.BackColor;
        }

        private void setAsHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserSettings.Home = browser.GetMainFrame().Url;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                browser.Load(txtAddress.Text);
            }
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            if (addUpdate)
            {
                txtAddress.Text = address;
                addUpdate = false;
            }
        }
    }
}
