using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class Form1 : Form
    {
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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
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
    }
}
