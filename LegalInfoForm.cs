using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsFinanceApp
{
    public partial class LegalInfoForm : Form
    {
        public LegalInfoForm()
        {
            InitializeComponent();
        }
        private void LegalInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;

            //Call the Process.Start method to open the default browser with a URL:
            System.Diagnostics.Process.Start("https://github.com/Brycerw11/WinFormsFinanceApp/blob/main/LICENSE");
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;

            //Call the Process.Start method to open the default browser with a URL:
            System.Diagnostics.Process.Start("https://dotnet.microsoft.com/en-us/");
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel3.LinkVisited = true;

            //Call the Process.Start method to open the default browser with a URL:
            System.Diagnostics.Process.Start("https://dotnet.microsoft.com/en-us/");
        }


        //Unused References
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
