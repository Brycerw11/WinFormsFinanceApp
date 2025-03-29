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
            this.debugLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(320, 127);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(123, 25);
            this.debugLabel.TabIndex = 0;
            this.debugLabel.Text = "Debug Label";
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 936);
            this.Controls.Add(this.debugLabel);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookForm_FormClosed);
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label debugLabel;
    }
}