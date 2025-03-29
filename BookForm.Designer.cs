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
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.changeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.fileTabPage.SuspendLayout();
            this.dataTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(26, 837);
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
            this.tabControl1.Size = new System.Drawing.Size(1330, 912);
            this.tabControl1.TabIndex = 1;
            // 
            // fileTabPage
            // 
            this.fileTabPage.Controls.Add(this.debugLabel);
            this.fileTabPage.Location = new System.Drawing.Point(4, 33);
            this.fileTabPage.Name = "fileTabPage";
            this.fileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.fileTabPage.Size = new System.Drawing.Size(1322, 875);
            this.fileTabPage.TabIndex = 0;
            this.fileTabPage.Text = "File";
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
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 936);
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
    }
}