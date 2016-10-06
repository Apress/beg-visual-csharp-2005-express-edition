namespace MultiLineTextBox
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
            this.multiLineBox = new System.Windows.Forms.TextBox();
            this.showLinesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // multiLineBox
            // 
            this.multiLineBox.Location = new System.Drawing.Point(12, 12);
            this.multiLineBox.Multiline = true;
            this.multiLineBox.Name = "multiLineBox";
            this.multiLineBox.Size = new System.Drawing.Size(268, 213);
            this.multiLineBox.TabIndex = 0;
            // 
            // showLinesButton
            // 
            this.showLinesButton.Location = new System.Drawing.Point(205, 231);
            this.showLinesButton.Name = "showLinesButton";
            this.showLinesButton.Size = new System.Drawing.Size(75, 23);
            this.showLinesButton.TabIndex = 1;
            this.showLinesButton.Text = "Show Lines";
            this.showLinesButton.Click += new System.EventHandler(this.showLinesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.showLinesButton);
            this.Controls.Add(this.multiLineBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox multiLineBox;
        private System.Windows.Forms.Button showLinesButton;
    }
}

