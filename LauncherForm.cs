using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            // get starting File Path
            newFileNameTextBox.Text = Path.GetFileNameWithoutExtension(newFileDialog.FileName);

            //Load Tooltips
            toolTip1.SetToolTip(this.newChosenFilePath, newFileNameTextBox.Text);
        }

        // Go to properties panel and click on view events to access event calls
        private void LauncherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Create File Section
        private void createFileBttn_Click(object sender, EventArgs e) 
        {
            // Check for a valid file path
            string path = newFileDialog.FileName;

            if (path.Substring(path.Length - 4) != ".fbf")
            {
                Debug.WriteLine(path);

                // Creates a dialog box for this form that informs the user that the file path is invalid
                DialogBoxForm dialogBox = new DialogBoxForm();
                dialogBox.dialogText = "An issued has occurred when trying to create a file at the specified file path. \n     The specifed file path may not exist. \n     You may not have the proper permissions to create a file in at specifed file path.";
                dialogBox.Text = "File Creation Error";

                dialogBox.ShowDialog();

                return;
            }

            try
            {
                File.WriteAllText(path, string.Empty);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            // Set up a new Form for the book
            BookForm newBook = new BookForm();
            newBook.bookFilePath = path;
            newBook.Text = Path.GetFileNameWithoutExtension(path) + " - Money Mage";
            
            // Show the new Form
            newBook.Show();

            //close the launcher form
            this.Hide();
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
                //Update File Path Tooltip
                toolTip1.SetToolTip(this.newChosenFilePath, newFileDialog.FileName);

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

        //Legal Information Button
        private void button2_Click(object sender, EventArgs e)
        {
            LegalInfoForm legalForm = new LegalInfoForm();
            legalForm.Show();
        }





        //Unused references

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
