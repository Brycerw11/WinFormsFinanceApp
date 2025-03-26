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
            this.recentFilesListBox = new System.Windows.Forms.ListBox();
            this.openFileBttn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newFileGroupBox = new System.Windows.Forms.GroupBox();
            this.newFileNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.createFileBttn = new System.Windows.Forms.Button();
            this.chooseFileLocationBttn = new System.Windows.Forms.Button();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.newFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.newChosenFilePath = new System.Windows.Forms.Label();
            this.openChosenFilePath = new System.Windows.Forms.Label();
            this.moneyMageFullLogo = new System.Windows.Forms.PictureBox();
            this.openFileGroupBox.SuspendLayout();
            this.newFileGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moneyMageFullLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // openFileGroupBox
            // 
            this.openFileGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.openFileGroupBox.Controls.Add(this.openChosenFilePath);
            this.openFileGroupBox.Controls.Add(this.recentFilesListBox);
            this.openFileGroupBox.Controls.Add(this.openFileBttn);
            this.openFileGroupBox.Controls.Add(this.button1);
            this.openFileGroupBox.Controls.Add(this.label1);
            this.openFileGroupBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.openFileGroupBox.Location = new System.Drawing.Point(75, 327);
            this.openFileGroupBox.Name = "openFileGroupBox";
            this.openFileGroupBox.Size = new System.Drawing.Size(869, 398);
            this.openFileGroupBox.TabIndex = 0;
            this.openFileGroupBox.TabStop = false;
            this.openFileGroupBox.Text = "Open File";
            // 
            // recentFilesListBox
            // 
            this.recentFilesListBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.recentFilesListBox.FormattingEnabled = true;
            this.recentFilesListBox.ItemHeight = 30;
            this.recentFilesListBox.Location = new System.Drawing.Point(44, 110);
            this.recentFilesListBox.Name = "recentFilesListBox";
            this.recentFilesListBox.Size = new System.Drawing.Size(788, 214);
            this.recentFilesListBox.TabIndex = 4;
            // 
            // openFileBttn
            // 
            this.openFileBttn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.openFileBttn.Location = new System.Drawing.Point(360, 333);
            this.openFileBttn.Name = "openFileBttn";
            this.openFileBttn.Size = new System.Drawing.Size(153, 53);
            this.openFileBttn.TabIndex = 3;
            this.openFileBttn.Text = "Open";
            this.openFileBttn.UseVisualStyleBackColor = true;
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
            // newFileGroupBox
            // 
            this.newFileGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.newFileGroupBox.Controls.Add(this.newChosenFilePath);
            this.newFileGroupBox.Controls.Add(this.newFileNameTextBox);
            this.newFileGroupBox.Controls.Add(this.label3);
            this.newFileGroupBox.Controls.Add(this.createFileBttn);
            this.newFileGroupBox.Controls.Add(this.chooseFileLocationBttn);
            this.newFileGroupBox.Controls.Add(this.filePathLabel);
            this.newFileGroupBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.newFileGroupBox.Location = new System.Drawing.Point(75, 147);
            this.newFileGroupBox.Name = "newFileGroupBox";
            this.newFileGroupBox.Size = new System.Drawing.Size(869, 178);
            this.newFileGroupBox.TabIndex = 1;
            this.newFileGroupBox.TabStop = false;
            this.newFileGroupBox.Text = "New File";
            // 
            // newFileNameTextBox
            // 
            this.newFileNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newFileNameTextBox.Location = new System.Drawing.Point(156, 53);
            this.newFileNameTextBox.Name = "newFileNameTextBox";
            this.newFileNameTextBox.Size = new System.Drawing.Size(466, 35);
            this.newFileNameTextBox.TabIndex = 9;
            this.newFileNameTextBox.TextChanged += new System.EventHandler(this.newFileNameTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(39, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "File Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // createFileBttn
            // 
            this.createFileBttn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createFileBttn.Location = new System.Drawing.Point(642, 43);
            this.createFileBttn.Name = "createFileBttn";
            this.createFileBttn.Size = new System.Drawing.Size(187, 53);
            this.createFileBttn.TabIndex = 6;
            this.createFileBttn.Text = "Create";
            this.createFileBttn.UseVisualStyleBackColor = true;
            this.createFileBttn.Click += new System.EventHandler(this.createFileBttn_Click);
            // 
            // chooseFileLocationBttn
            // 
            this.chooseFileLocationBttn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chooseFileLocationBttn.Location = new System.Drawing.Point(641, 109);
            this.chooseFileLocationBttn.Name = "chooseFileLocationBttn";
            this.chooseFileLocationBttn.Size = new System.Drawing.Size(191, 46);
            this.chooseFileLocationBttn.TabIndex = 5;
            this.chooseFileLocationBttn.Text = "Choose Location";
            this.chooseFileLocationBttn.UseVisualStyleBackColor = true;
            this.chooseFileLocationBttn.Click += new System.EventHandler(this.chooseFileLocationBttn_Click);
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.filePathLabel.Location = new System.Drawing.Point(38, 119);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(96, 30);
            this.filePathLabel.TabIndex = 4;
            this.filePathLabel.Text = "File Path:";
            this.filePathLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // newFileDialog
            // 
            this.newFileDialog.DefaultExt = "fbf";
            this.newFileDialog.FileName = "Book1";
            this.newFileDialog.Filter = "Financial Book files|*.fbf|All Files|*.*";
            this.newFileDialog.Title = "Create a new Financial Book file";
            this.newFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.newFileDialog_FileOk);
            // 
            // newChosenFilePath
            // 
            this.newChosenFilePath.AutoEllipsis = true;
            this.newChosenFilePath.AutoSize = true;
            this.newChosenFilePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newChosenFilePath.Location = new System.Drawing.Point(151, 119);
            this.newChosenFilePath.MaximumSize = new System.Drawing.Size(500, 50);
            this.newChosenFilePath.Name = "newChosenFilePath";
            this.newChosenFilePath.Size = new System.Drawing.Size(212, 30);
            this.newChosenFilePath.TabIndex = 10;
            this.newChosenFilePath.Text = "No File Path Provided";
            this.newChosenFilePath.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // openChosenFilePath
            // 
            this.openChosenFilePath.AutoEllipsis = true;
            this.openChosenFilePath.AutoSize = true;
            this.openChosenFilePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.openChosenFilePath.Location = new System.Drawing.Point(154, 54);
            this.openChosenFilePath.MaximumSize = new System.Drawing.Size(500, 50);
            this.openChosenFilePath.Name = "openChosenFilePath";
            this.openChosenFilePath.Size = new System.Drawing.Size(212, 30);
            this.openChosenFilePath.TabIndex = 11;
            this.openChosenFilePath.Text = "No File Path Provided";
            // 
            // moneyMageFullLogo
            // 
            this.moneyMageFullLogo.Location = new System.Drawing.Point(214, 12);
            this.moneyMageFullLogo.Name = "moneyMageFullLogo";
            this.moneyMageFullLogo.Size = new System.Drawing.Size(548, 129);
            this.moneyMageFullLogo.TabIndex = 2;
            this.moneyMageFullLogo.TabStop = false;
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(976, 736);
            this.Controls.Add(this.moneyMageFullLogo);
            this.Controls.Add(this.newFileGroupBox);
            this.Controls.Add(this.openFileGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "LauncherForm";
            this.Text = "Money Mage";
            this.Load += new System.EventHandler(this.LauncherForm_Load);
            this.openFileGroupBox.ResumeLayout(false);
            this.openFileGroupBox.PerformLayout();
            this.newFileGroupBox.ResumeLayout(false);
            this.newFileGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moneyMageFullLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox openFileGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button openFileBttn;
        private System.Windows.Forms.ListBox recentFilesListBox;
        private System.Windows.Forms.GroupBox newFileGroupBox;
        private System.Windows.Forms.Button chooseFileLocationBttn;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.Button createFileBttn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newFileNameTextBox;
        private System.Windows.Forms.SaveFileDialog newFileDialog;
        private System.Windows.Forms.Label newChosenFilePath;
        private System.Windows.Forms.Label openChosenFilePath;
        private System.Windows.Forms.PictureBox moneyMageFullLogo;
    }
}

