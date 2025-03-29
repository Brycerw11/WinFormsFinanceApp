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
    public partial class DialogBoxForm : Form
    {

        public string dialogText = "Show Dialog Text Here";

        public DialogBoxForm()
        {
            InitializeComponent();
        }

        private void DialogBoxForm_Load(object sender, EventArgs e)
        {
            label1.Text = dialogText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
