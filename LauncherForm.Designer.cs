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
            this.openFileGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // openFileGroupBox
            // 
            this.openFileGroupBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.openFileGroupBox.Controls.Add(this.button1);
            this.openFileGroupBox.Controls.Add(this.label1);
            this.openFileGroupBox.Controls.Add(this.openFileTextBox);
            this.openFileGroupBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.openFileGroupBox.Location = new System.Drawing.Point(75, 44);
            this.openFileGroupBox.Name = "openFileGroupBox";
            this.openFileGroupBox.Size = new System.Drawing.Size(832, 255);
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
            this.button1.Size = new System.Drawing.Size(153, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Choose File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(976, 636);
            this.Controls.Add(this.openFileGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "LauncherForm";
            this.Text = "Personal Finance Application";
            this.Load += new System.EventHandler(this.LauncherForm_Load);
            this.openFileGroupBox.ResumeLayout(false);
            this.openFileGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox openFileGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox openFileTextBox;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

