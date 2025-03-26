using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            newFileNameTextBox.Text = Path.GetFileNameWithoutExtension(newFileDialog.FileName);
        }

        //Create File Section
        private void createFileBttn_Click(object sender, EventArgs e)
        {

        }
        private void newFileNameTextBox_TextChanged(object sender, EventArgs e)
        {
            //Updates file path label
            if (newFileNameTextBox.Text != string.Empty)
            {
                newFileDialog.FileName = newFileNameTextBox.Text;
            }
        }
        private void chooseFileLocationBttn_Click(object sender, EventArgs e)
        {
            if(newFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Update File Path Text
                newChosenFilePath.Text = newFileDialog.FileName;

                //Update File Name Text Box
                newFileNameTextBox.Text = Path.GetFileNameWithoutExtension(newFileDialog.FileName);
            }
        }


        //Open File Section
        //button1 is the "Choose File" button
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //sets the file path text box to the selected path
                openChosenFilePath.Text = openFileDialog.FileName;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void newFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
