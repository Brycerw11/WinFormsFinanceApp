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
using System.Text.Json;
using System.Diagnostics;

namespace WinFormsFinanceApp
{
    public partial class BookForm : Form
    {
        public string bookName;
        public string bookFilePath;

        public BookForm()
        {
            InitializeComponent();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            this.Text = bookName + " - MoneyMage"; //update form title

            //Update File data in file tab
            filePathLabel.Text = bookFilePath;
            updateBookFileInfo();

            //Update listBox in Input Data tab
            listBox1.Items.Clear();
        }

        private void BookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void updateBookFileInfo()
        {
            bookNameLabel.Text = bookName;
            fileCreationDateLabel.Text = File.GetLastWriteTime(bookFilePath).ToString();
        }

        //View Legal Info Button
        private void button2_Click(object sender, EventArgs e)
        {
            LegalInfoForm legalForm = new LegalInfoForm();
            legalForm.Show();
        }

        //Close Program Button Pressed
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Close Book Button Pressed
        private void button1_Click(object sender, EventArgs e)
        {
            //Create new launcher form
            LauncherForm homeForm = new LauncherForm();

            //Show new form and hide this form
            homeForm.Show();
            this.Hide();
        }



        //Input Data Tab
        private FinanceItem[] items = { };

        private void LoadSavedItems()
        {

        }

        //Create new data item
        private void newDataItemButton_Click(object sender, EventArgs e)
        {
            FinanceItem coolItem = new FinanceItem();

            //Add the new item to the array of items
            items = items.Append<FinanceItem>(coolItem).ToArray();

            //Ensure each item has a unique name
            int iterations = 1;
            while (listBox1.Items.Contains(coolItem.GetItemString()))
            {
                coolItem.Name = "Item " + iterations.ToString();
                iterations++;
            }

            //Add the item to the listBox
            listBox1.Items.Add(coolItem.GetItemString());

            //Select the newly added item
            listBox1.SelectedItems.Clear();
            listBox1.SelectedItems.Add(coolItem.GetItemString());

            SaveFile();
        }

        private void SaveFile()
        {
            string jsonText = "";
            for(int i =0; i < items.Length; i++)
            {
                jsonText += JsonSerializer.Serialize(items[i]) +"\n";
            }
            File.WriteAllText(bookFilePath, jsonText);
        }


        //Unused References
        private void fileTabPage_Click(object sender, EventArgs e)
        {

        }
    }
}
