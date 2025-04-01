namespace WinFormsFinanceApp
{
    partial class BookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.fileTabPage = new System.Windows.Forms.TabPage();
            this.overviewTabPage = new System.Windows.Forms.TabPage();
            this.tableTabPage = new System.Windows.Forms.TabPage();
            this.dataTabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.fileCreationDateLabel = new System.Windows.Forms.Label();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.newDataItemButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.fileTabPage.SuspendLayout();
            this.dataTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.fileTabPage);
            this.tabControl1.Controls.Add(this.overviewTabPage);
            this.tabControl1.Controls.Add(this.tableTabPage);
            this.tabControl1.Controls.Add(this.dataTabPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(17, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1330, 868);
            this.tabControl1.TabIndex = 1;
            // 
            // fileTabPage
            // 
            this.fileTabPage.Controls.Add(this.filePathLabel);
            this.fileTabPage.Controls.Add(this.fileCreationDateLabel);
            this.fileTabPage.Controls.Add(this.bookNameLabel);
            this.fileTabPage.Controls.Add(this.button4);
            this.fileTabPage.Controls.Add(this.button3);
            this.fileTabPage.Controls.Add(this.button1);
            this.fileTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileTabPage.Location = new System.Drawing.Point(4, 41);
            this.fileTabPage.Name = "fileTabPage";
            this.fileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.fileTabPage.Size = new System.Drawing.Size(1322, 823);
            this.fileTabPage.TabIndex = 0;
            this.fileTabPage.Text = "File";
            this.fileTabPage.Click += new System.EventHandler(this.fileTabPage_Click);
            // 
            // overviewTabPage
            // 
            this.overviewTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overviewTabPage.Location = new System.Drawing.Point(4, 41);
            this.overviewTabPage.Name = "overviewTabPage";
            this.overviewTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.overviewTabPage.Size = new System.Drawing.Size(1322, 823);
            this.overviewTabPage.TabIndex = 1;
            this.overviewTabPage.Text = "Overview";
            // 
            // tableTabPage
            // 
            this.tableTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableTabPage.Location = new System.Drawing.Point(4, 41);
            this.tableTabPage.Name = "tableTabPage";
            this.tableTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tableTabPage.Size = new System.Drawing.Size(1322, 823);
            this.tableTabPage.TabIndex = 2;
            this.tableTabPage.Text = "Table View";
            // 
            // dataTabPage
            // 
            this.dataTabPage.Controls.Add(this.listBox1);
            this.dataTabPage.Controls.Add(this.groupBox1);
            this.dataTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTabPage.Location = new System.Drawing.Point(4, 41);
            this.dataTabPage.Name = "dataTabPage";
            this.dataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataTabPage.Size = new System.Drawing.Size(1322, 823);
            this.dataTabPage.TabIndex = 3;
            this.dataTabPage.Text = "Input Data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.newDataItemButton);
            this.groupBox1.Location = new System.Drawing.Point(787, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 790);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modify Data";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.button2.Location = new System.Drawing.Point(1115, 882);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "View Legal Information";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 895);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "MoneyMage © 2025 Bryce Wahl";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(510, 750);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(38, 750);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(307, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "Save File";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(976, 750);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(307, 58);
            this.button4.TabIndex = 3;
            this.button4.Text = "Close Program";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameLabel.Location = new System.Drawing.Point(30, 31);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(237, 48);
            this.bookNameLabel.TabIndex = 4;
            this.bookNameLabel.Text = "Book Name";
            // 
            // fileCreationDateLabel
            // 
            this.fileCreationDateLabel.AutoSize = true;
            this.fileCreationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileCreationDateLabel.Location = new System.Drawing.Point(33, 79);
            this.fileCreationDateLabel.Name = "fileCreationDateLabel";
            this.fileCreationDateLabel.Size = new System.Drawing.Size(157, 29);
            this.fileCreationDateLabel.TabIndex = 5;
            this.fileCreationDateLabel.Text = "Last Modified";
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Location = new System.Drawing.Point(33, 119);
            this.filePathLabel.MaximumSize = new System.Drawing.Size(1265, 25);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(94, 25);
            this.filePathLabel.TabIndex = 6;
            this.filePathLabel.Text = "File Path:";
            // 
            // newDataItemButton
            // 
            this.newDataItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newDataItemButton.Location = new System.Drawing.Point(27, 720);
            this.newDataItemButton.Name = "newDataItemButton";
            this.newDataItemButton.Size = new System.Drawing.Size(219, 51);
            this.newDataItemButton.TabIndex = 0;
            this.newDataItemButton.Text = "New Data Item";
            this.newDataItemButton.UseVisualStyleBackColor = true;
            this.newDataItemButton.Click += new System.EventHandler(this.newDataItemButton_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(269, 720);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(219, 51);
            this.button6.TabIndex = 1;
            this.button6.Text = "Delete Data Item";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Name:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(169, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 39);
            this.textBox1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(197, 492);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(272, 34);
            this.numericUpDown1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item Value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Item Description:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(32, 162);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(453, 214);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 548);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Item Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 548);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(316, 34);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(153, 607);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(316, 34);
            this.dateTimePicker2.TabIndex = 12;
            this.dateTimePicker2.Value = new System.DateTime(2025, 3, 31, 23, 13, 42, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 608);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Item Time:";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Items.AddRange(new object[] {
            "Item Name 1 - Price",
            "Item Name 2 - Price",
            "Item Name 3 - Price",
            "Item Name 4 - Price"});
            this.listBox1.Location = new System.Drawing.Point(18, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(727, 754);
            this.listBox1.TabIndex = 3;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 936);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.HelpButton = true;
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookForm_FormClosed);
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.fileTabPage.ResumeLayout(false);
            this.fileTabPage.PerformLayout();
            this.dataTabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage fileTabPage;
        private System.Windows.Forms.TabPage overviewTabPage;
        private System.Windows.Forms.TabPage tableTabPage;
        private System.Windows.Forms.TabPage dataTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label fileCreationDateLabel;
        private System.Windows.Forms.Label bookNameLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.Button newDataItemButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
    }
}