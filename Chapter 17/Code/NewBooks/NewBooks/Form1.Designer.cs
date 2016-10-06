namespace NewBooks
{
    partial class Form1
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
            this.bookList = new System.Windows.Forms.ListBox();
            this.bookCheckButton = new System.Windows.Forms.Button();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.downloadProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // bookList
            // 
            this.bookList.FormattingEnabled = true;
            this.bookList.Location = new System.Drawing.Point(12, 40);
            this.bookList.Name = "bookList";
            this.bookList.Size = new System.Drawing.Size(410, 355);
            this.bookList.Sorted = true;
            this.bookList.TabIndex = 0;
            this.bookList.DoubleClick += new System.EventHandler(this.bookList_DoubleClick);
            // 
            // bookCheckButton
            // 
            this.bookCheckButton.Location = new System.Drawing.Point(304, 11);
            this.bookCheckButton.Name = "bookCheckButton";
            this.bookCheckButton.Size = new System.Drawing.Size(118, 23);
            this.bookCheckButton.TabIndex = 1;
            this.bookCheckButton.Text = "Check for books";
            this.bookCheckButton.Click += new System.EventHandler(this.bookCheckButton_Click);
            // 
            // browser
            // 
            this.browser.Location = new System.Drawing.Point(0, 0);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(282, 34);
            this.browser.TabIndex = 0;
            this.browser.Visible = false;
            // 
            // downloadProgress
            // 
            this.downloadProgress.Location = new System.Drawing.Point(12, 401);
            this.downloadProgress.Name = "downloadProgress";
            this.downloadProgress.Size = new System.Drawing.Size(410, 23);
            this.downloadProgress.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 447);
            this.Controls.Add(this.downloadProgress);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.bookCheckButton);
            this.Controls.Add(this.bookList);
            this.Name = "Form1";
            this.Text = "Find forthcoming Apress Books";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox bookList;
        private System.Windows.Forms.Button bookCheckButton;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.ProgressBar downloadProgress;
    }
}

