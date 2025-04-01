using Microsoft.Win32.SafeHandles;
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
    public partial class BookForm : Form
    {
        public string bookFilePath;

        public BookForm()
        {
            InitializeComponent();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            debugLabel.Text = bookFilePath;
            updateBookFileInfo();
        }

        private void BookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void updateBookFileInfo()
        {
            fileCreationDateLabel.Text = File.GetLastWriteTime(bookFilePath).ToString();
        }

        //View Legal Info Button
        private void button2_Click(object sender, EventArgs e)
        {
            LegalInfoForm legalForm = new LegalInfoForm();
            legalForm.Show();
        }


        //Unused References
        private void fileTabPage_Click(object sender, EventArgs e)
        {

        }
    }
}
