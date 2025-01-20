namespace WinFormsFinanceApp
{
    partial class LauncherForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileGroupBox = new System.Windows.Forms.GroupBox();
            this.openFileTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileBttn = new System.Windows.Forms.Button();
            this.recentFilesListBox = new System.Windows.Forms.ListBox();
            this.newFileGroupBox = new System.Windows.Forms.GroupBox();
            this.chooseFileLocationBttn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.newFileLocationTextBox = new System.Windows.Forms.TextBox();
            this.createFileBttn = new System.Windows.Forms.Button();
            this.newFilePathLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newFileNameTextBox = new System.Windows.Forms.TextBox();
            this.newFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.newFileLocationFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileGroupBox.SuspendLayout();
            this.newFileGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // openFileGroupBox
            // 
            this.openFileGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.openFileGroupBox.Controls.Add(this.recentFilesListBox);
            this.openFileGroupBox.Controls.Add(this.openFileBttn);
            this.openFileGroupBox.Controls.Add(this.button1);
            this.openFileGroupBox.Controls.Add(this.label1);
            this.openFileGroupBox.Controls.Add(this.openFileTextBox);
            this.openFileGroupBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.openFileGroupBox.Location = new System.Drawing.Point(75, 260);
            this.openFileGroupBox.Name = "openFileGroupBox";
            this.openFileGroupBox.Size = new System.Drawing.Size(869, 441);
            this.openFileGroupBox.TabIndex = 0;
            this.openFileGroupBox.TabStop = false;
            this.openFileGroupBox.Text = "Open File";
            // 
            // openFileTextBox
            // 
            this.openFileTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.openFileTextBox.Location = new System.Drawing.Point(141, 53);
            this.openFileTextBox.Name = "openFileTextBox";
            this.openFileTextBox.Size = new System.Drawing.Size(481, 35);
            this.openFileTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(39, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Path:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Location = new System.Drawing.Point(642, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Choose File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileBttn
            // 
            this.openFileBttn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.openFileBttn.Location = new System.Drawing.Point(360, 369);
            this.openFileBttn.Name = "openFileBttn";
            this.openFileBttn.Size = new System.Drawing.Size(153, 53);
            this.openFileBttn.TabIndex = 3;
            this.openFileBttn.Text = "Open";
            this.openFileBttn.UseVisualStyleBackColor = true;
            // 
            // recentFilesListBox
            // 
            this.recentFilesListBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.recentFilesListBox.FormattingEnabled = true;
            this.recentFilesListBox.ItemHeight = 30;
            this.recentFilesListBox.Location = new System.Drawing.Point(44, 110);
            this.recentFilesListBox.Name = "recentFilesListBox";
            this.recentFilesListBox.Size = new System.Drawing.Size(788, 244);
            this.recentFilesListBox.TabIndex = 4;
            // 
            // newFileGroupBox
            // 
            this.newFileGroupBox.Controls.Add(this.newFileNameTextBox);
            this.newFileGroupBox.Controls.Add(this.label3);
            this.newFileGroupBox.Controls.Add(this.newFilePathLabel);
            this.newFileGroupBox.Controls.Add(this.createFileBttn);
            this.newFileGroupBox.Controls.Add(this.chooseFileLocationBttn);
            this.newFileGroupBox.Controls.Add(this.label2);
            this.newFileGroupBox.Controls.Add(this.newFileLocationTextBox);
            this.newFileGroupBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.newFileGroupBox.Location = new System.Drawing.Point(75, 42);
            this.newFileGroupBox.Name = "newFileGroupBox";
            this.newFileGroupBox.Size = new System.Drawing.Size(869, 212);
            this.newFileGroupBox.TabIndex = 1;
            this.newFileGroupBox.TabStop = false;
            this.newFileGroupBox.Text = "New File";
            // 
            // chooseFileLocationBttn
            // 
            this.chooseFileLocationBttn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chooseFileLocationBttn.Location = new System.Drawing.Point(641, 109);
            this.chooseFileLocationBttn.Name = "chooseFileLocationBttn";
            this.chooseFileLocationBttn.Size = new System.Drawing.Size(191, 53);
            this.chooseFileLocationBttn.TabIndex = 5;
            this.chooseFileLocationBttn.Text = "Choose Location";
            this.chooseFileLocationBttn.UseVisualStyleBackColor = true;
            this.chooseFileLocationBttn.Click += new System.EventHandler(this.chooseFileLocationBttn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(38, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "File Location:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // newFileLocationTextBox
            // 
            this.newFileLocationTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newFileLocationTextBox.Location = new System.Drawing.Point(175, 119);
            this.newFileLocationTextBox.Name = "newFileLocationTextBox";
            this.newFileLocationTextBox.Size = new System.Drawing.Size(446, 35);
            this.newFileLocationTextBox.TabIndex = 3;
            // 
            // createFileBttn
            // 
            this.createFileBttn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createFileBttn.Location = new System.Drawing.Point(600, 41);
            this.createFileBttn.Name = "createFileBttn";
            this.createFileBttn.Size = new System.Drawing.Size(170, 53);
            this.createFileBttn.TabIndex = 6;
            this.createFileBttn.Text = "Create";
            this.createFileBttn.UseVisualStyleBackColor = true;
            this.createFileBttn.Click += new System.EventHandler(this.createFileBttn_Click);
            // 
            // newFilePathLabel
            // 
            this.newFilePathLabel.AutoEllipsis = true;
            this.newFilePathLabel.AutoSize = true;
            this.newFilePathLabel.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.newFilePathLabel.Location = new System.Drawing.Point(94, 167);
            this.newFilePathLabel.Name = "newFilePathLabel";
            this.newFilePathLabel.Size = new System.Drawing.Size(78, 23);
            this.newFilePathLabel.TabIndex = 7;
            this.newFilePathLabel.Text = "File Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(115, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "File Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // newFileNameTextBox
            // 
            this.newFileNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newFileNameTextBox.Location = new System.Drawing.Point(229, 52);
            this.newFileNameTextBox.Name = "newFileNameTextBox";
            this.newFileNameTextBox.Size = new System.Drawing.Size(351, 35);
            this.newFileNameTextBox.TabIndex = 9;
            this.newFileNameTextBox.TextChanged += new System.EventHandler(this.newFileNameTextBox_TextChanged);
            // 
            // newFileDialog
            // 
            this.newFileDialog.CreatePrompt = true;
            // 
            // newFileLocationFolderDialog
            // 
            this.newFileLocationFolderDialog.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(976, 736);
            this.Controls.Add(this.newFileGroupBox);
            this.Controls.Add(this.openFileGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "LauncherForm";
            this.Text = "Personal Finance Application";
            this.Load += new System.EventHandler(this.LauncherForm_Load);
            this.openFileGroupBox.ResumeLayout(false);
            this.openFileGroupBox.PerformLayout();
            this.newFileGroupBox.ResumeLayout(false);
            this.newFileGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox openFileGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox openFileTextBox;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button openFileBttn;
        private System.Windows.Forms.ListBox recentFilesListBox;
        private System.Windows.Forms.GroupBox newFileGroupBox;
        private System.Windows.Forms.Button chooseFileLocationBttn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newFileLocationTextBox;
        private System.Windows.Forms.Button createFileBttn;
        private System.Windows.Forms.Label newFilePathLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newFileNameTextBox;
        private System.Windows.Forms.SaveFileDialog newFileDialog;
        private System.Windows.Forms.FolderBrowserDialog newFileLocationFolderDialog;
    }
}

