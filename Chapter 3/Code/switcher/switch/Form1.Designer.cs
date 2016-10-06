namespace switcher
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
            this.label1 = new System.Windows.Forms.Label();
            this.userType = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
// 
// label1
// 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "So, what are you? Male, Female..what?";
// 
// userType
// 
            this.userType.Location = new System.Drawing.Point(18, 39);
            this.userType.Name = "userType";
            this.userType.Size = new System.Drawing.Size(284, 22);
            this.userType.TabIndex = 1;
// 
// button1
// 
            this.button1.Location = new System.Drawing.Point(197, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
// 
// Form1
// 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(319, 118);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userType);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userType;
        private System.Windows.Forms.Button button1;
	}
}

