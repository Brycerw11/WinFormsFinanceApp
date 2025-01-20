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

        //Create File Section
        private void createFileBttn_Click(object sender, EventArgs e)
        {

        }
        private void newFileNameTextBox_TextChanged(object sender, EventArgs e)
        {
            //Updates file path label
            if (newFilePathLabel.Text != string.Empty && newFileNameTextBox.Text != string.Empty)
            {
                newFilePathLabel.Text = newFileLocationTextBox.Text + @"\" + newFileNameTextBox.Text + ".insertfileextensionhere";
            }
        }
        private void chooseFileLocationBttn_Click(object sender, EventArgs e)
        {
            if(newFileLocationFolderDialog.ShowDialog() == DialogResult.OK)
            {
                newFileLocationTextBox.Text = newFileLocationFolderDialog.SelectedPath;
                //Updates file path label
                if (newFilePathLabel.Text != string.Empty && newFileNameTextBox.Text != string.Empty)
                {
                    newFilePathLabel.Text = newFileLocationTextBox.Text + @"\" + newFileNameTextBox.Text + ".insertfileextensionhere";
                }
            }
        }


        //Open File Section
        //button1 is the "Choose File" button
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


    }
}
