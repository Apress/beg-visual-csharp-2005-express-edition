namespace AddingToListBox
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
            this.demoListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newItemBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // demoListBox
            // 
            this.demoListBox.FormattingEnabled = true;
            this.demoListBox.Items.AddRange(new object[] {
            ""});
            this.demoListBox.Location = new System.Drawing.Point(12, 12);
            this.demoListBox.Name = "demoListBox";
            this.demoListBox.Size = new System.Drawing.Size(350, 277);
            this.demoListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "New item";
            // 
            // newItemBox
            // 
            this.newItemBox.Location = new System.Drawing.Point(64, 302);
            this.newItemBox.Name = "newItemBox";
            this.newItemBox.Size = new System.Drawing.Size(217, 20);
            this.newItemBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(287, 299);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 333);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.newItemBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.demoListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox demoListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newItemBox;
        private System.Windows.Forms.Button addButton;
    }
}

