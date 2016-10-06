namespace FileWatcher
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
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.watcher = new System.IO.FileSystemWatcher();
            this.folderLabel = new System.Windows.Forms.Label();
            this.chooseButton = new System.Windows.Forms.Button();
            this.changesList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.watcher)).BeginInit();
            this.SuspendLayout();
            // 
            // watcher
            // 
            this.watcher.SynchronizingObject = this;
            this.watcher.Created += new System.IO.FileSystemEventHandler(this.watcher_Created);
            this.watcher.Deleted += new System.IO.FileSystemEventHandler(this.watcher_Deleted);
            this.watcher.Renamed += new System.IO.RenamedEventHandler(this.watcher_Renamed);
            this.watcher.Changed += new System.IO.FileSystemEventHandler(this.watcher_Changed);
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Location = new System.Drawing.Point(93, 15);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(291, 17);
            this.folderLabel.TabIndex = 0;
            this.folderLabel.Text = "Click the button to choose the folder to watch";
            // 
            // chooseButton
            // 
            this.chooseButton.Location = new System.Drawing.Point(12, 12);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(75, 23);
            this.chooseButton.TabIndex = 1;
            this.chooseButton.Text = "Choose";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.chooseButton_Click);
            // 
            // changesList
            // 
            this.changesList.FormattingEnabled = true;
            this.changesList.ItemHeight = 16;
            this.changesList.Location = new System.Drawing.Point(12, 41);
            this.changesList.Name = "changesList";
            this.changesList.Size = new System.Drawing.Size(372, 260);
            this.changesList.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 327);
            this.Controls.Add(this.changesList);
            this.Controls.Add(this.chooseButton);
            this.Controls.Add(this.folderLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.watcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.IO.FileSystemWatcher watcher;
        private System.Windows.Forms.ListBox changesList;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.Label folderLabel;
    }
}

