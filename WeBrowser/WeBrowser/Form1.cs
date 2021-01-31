using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btNatrag_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void webBrowser1_CamGoBackChanged(object sender, EventArgs e) 
        {
            btNatrag.Enabled = webBrowser1.CanGoBack;
        }

        private void btNaprijed_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        
        private void webBrowser1_CamGoFowardChanged(object sender, EventArgs e)
        {
            btNaprijed.Enabled = webBrowser1.CanGoForward;
        }

        private void btnIdi_Click(object sender, EventArgs e)
        {

            webBrowser1.Navigate(txtAdresa.Text);
        }

        private void txtAdresa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }

        private void btnWebmail_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://webmail.carnet.hr/login.php");
        }

        private void btnGmail_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://mail.google.com/");
        }
        
        private void Navigate(string adresa)
        {
            if (String.IsNullOrEmpty(adresa)) return;
            if (adresa.Equals("about:blank")) return;
            if (!adresa.StartsWith("https://") && !adresa.StartsWith("http://"))
            {
                adresa = "http://" + adresa;
            }
            try
            {
                webBrowser1.Navigate(new Uri(adresa));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        private void txtAdresa_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Navigate(txtAdresa.Text);
            }
        }
    }
}