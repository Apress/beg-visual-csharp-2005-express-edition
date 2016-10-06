namespace Division
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
            this.divisorBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dividendBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
// 
// divisorBox
// 
            this.divisorBox.Location = new System.Drawing.Point(18, 15);
            this.divisorBox.Name = "divisorBox";
            this.divisorBox.Size = new System.Drawing.Size(65, 22);
            this.divisorBox.TabIndex = 0;
// 
// label1
// 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "divided by";
// 
// dividendBox
// 
            this.dividendBox.Location = new System.Drawing.Point(179, 15);
            this.dividendBox.Name = "dividendBox";
            this.dividendBox.Size = new System.Drawing.Size(65, 22);
            this.dividendBox.TabIndex = 2;
// 
// button1
// 
            this.button1.Location = new System.Drawing.Point(139, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Divide";
            this.button1.Click += new System.EventHandler(this.button1_Click);
// 
// Form1
// 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(269, 85);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dividendBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.divisorBox);
            this.Name = "Form1";
            this.Text = "Integer division";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox divisorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dividendBox;
        private System.Windows.Forms.Button button1;
    }
}

