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
        }

        private void BookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
