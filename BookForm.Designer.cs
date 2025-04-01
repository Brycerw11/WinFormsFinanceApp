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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("");
            this.debugLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.fileTabPage = new System.Windows.Forms.TabPage();
            this.overviewTabPage = new System.Windows.Forms.TabPage();
            this.tableTabPage = new System.Windows.Forms.TabPage();
            this.dataTabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.changeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.fileCreationDateLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.fileTabPage.SuspendLayout();
            this.dataTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(26, 781);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(123, 25);
            this.debugLabel.TabIndex = 0;
            this.debugLabel.Text = "Debug Label";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.fileTabPage);
            this.tabControl1.Controls.Add(this.overviewTabPage);
            this.tabControl1.Controls.Add(this.tableTabPage);
            this.tabControl1.Controls.Add(this.dataTabPage);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(17, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1330, 868);
            this.tabControl1.TabIndex = 1;
            // 
            // fileTabPage
            // 
            this.fileTabPage.Controls.Add(this.fileCreationDateLabel);
            this.fileTabPage.Controls.Add(this.bookNameLabel);
            this.fileTabPage.Controls.Add(this.button4);
            this.fileTabPage.Controls.Add(this.button3);
            this.fileTabPage.Controls.Add(this.button1);
            this.fileTabPage.Controls.Add(this.debugLabel);
            this.fileTabPage.Location = new System.Drawing.Point(4, 33);
            this.fileTabPage.Name = "fileTabPage";
            this.fileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.fileTabPage.Size = new System.Drawing.Size(1322, 831);
            this.fileTabPage.TabIndex = 0;
            this.fileTabPage.Text = "File";
            this.fileTabPage.Click += new System.EventHandler(this.fileTabPage_Click);
            // 
            // overviewTabPage
            // 
            this.overviewTabPage.Location = new System.Drawing.Point(4, 33);
            this.overviewTabPage.Name = "overviewTabPage";
            this.overviewTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.overviewTabPage.Size = new System.Drawing.Size(1322, 875);
            this.overviewTabPage.TabIndex = 1;
            this.overviewTabPage.Text = "Overview";
            // 
            // tableTabPage
            // 
            this.tableTabPage.Location = new System.Drawing.Point(4, 33);
            this.tableTabPage.Name = "tableTabPage";
            this.tableTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tableTabPage.Size = new System.Drawing.Size(1322, 875);
            this.tableTabPage.TabIndex = 2;
            this.tableTabPage.Text = "Table View";
            // 
            // dataTabPage
            // 
            this.dataTabPage.Controls.Add(this.groupBox1);
            this.dataTabPage.Controls.Add(this.listView1);
            this.dataTabPage.Location = new System.Drawing.Point(4, 33);
            this.dataTabPage.Name = "dataTabPage";
            this.dataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataTabPage.Size = new System.Drawing.Size(1322, 875);
            this.dataTabPage.TabIndex = 3;
            this.dataTabPage.Text = "Input Data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.changeDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(903, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 712);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modify Data";
            // 
            // changeDateTimePicker
            // 
            this.changeDateTimePicker.Location = new System.Drawing.Point(25, 47);
            this.changeDateTimePicker.Name = "changeDateTimePicker";
            this.changeDateTimePicker.Size = new System.Drawing.Size(345, 29);
            this.changeDateTimePicker.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.listView1.Location = new System.Drawing.Point(27, 60);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(727, 792);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            this.button1.Location = new System.Drawing.Point(470, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(392, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open / Create A Different File";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Save File";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(31, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(210, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "Close Program";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameLabel.Location = new System.Drawing.Point(31, 28);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(213, 42);
            this.bookNameLabel.TabIndex = 4;
            this.bookNameLabel.Text = "Book Name";
            // 
            // fileCreationDateLabel
            // 
            this.fileCreationDateLabel.AutoSize = true;
            this.fileCreationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileCreationDateLabel.Location = new System.Drawing.Point(33, 70);
            this.fileCreationDateLabel.Name = "fileCreationDateLabel";
            this.fileCreationDateLabel.Size = new System.Drawing.Size(157, 29);
            this.fileCreationDateLabel.TabIndex = 5;
            this.fileCreationDateLabel.Text = "Last Modified";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage fileTabPage;
        private System.Windows.Forms.TabPage overviewTabPage;
        private System.Windows.Forms.TabPage tableTabPage;
        private System.Windows.Forms.TabPage dataTabPage;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker changeDateTimePicker;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label fileCreationDateLabel;
        private System.Windows.Forms.Label bookNameLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}