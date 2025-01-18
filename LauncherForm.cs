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
    public partial class LauncherForm : Form
    {
        public LauncherForm()
        {
            InitializeComponent();
        }

        private void LauncherForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //sets the file path text box to the selected path
                openFileTextBox.Text = openFileDialog.FileName;
            }
        }


        //Unused references
        private void selectedFilePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
