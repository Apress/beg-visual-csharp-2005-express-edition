namespace Calculator
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
			this.label1 = new System.Windows.Forms.Label();
			this.value1Box = new System.Windows.Forms.TextBox();
			this.operation = new System.Windows.Forms.ComboBox();
			this.value2Box = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.calculateButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.resultBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 14);
			this.label1.TabIndex = 0;
			this.label1.Text = "Value 1";
			// 
			// value1Box
			// 
			this.value1Box.Location = new System.Drawing.Point(12, 32);
			this.value1Box.Name = "value1Box";
			this.value1Box.Size = new System.Drawing.Size(56, 20);
			this.value1Box.TabIndex = 1;
			// 
			// operation
			// 
			this.operation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.operation.FormattingEnabled = true;
			this.operation.Items.AddRange(new object[] {
            "Add",
            "Subtract",
            "Multiply",
            "Divide"});
			this.operation.Location = new System.Drawing.Point(74, 31);
			this.operation.Name = "operation";
			this.operation.TabIndex = 2;
			// 
			// value2Box
			// 
			this.value2Box.Location = new System.Drawing.Point(201, 32);
			this.value2Box.Name = "value2Box";
			this.value2Box.Size = new System.Drawing.Size(56, 20);
			this.value2Box.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(201, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 14);
			this.label2.TabIndex = 4;
			this.label2.Text = "Value 2";
			// 
			// calculateButton
			// 
			this.calculateButton.Location = new System.Drawing.Point(273, 29);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.TabIndex = 5;
			this.calculateButton.Text = "Calculate";
			this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(96, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 14);
			this.label3.TabIndex = 6;
			this.label3.Text = "Result";
			// 
			// resultBox
			// 
			this.resultBox.Location = new System.Drawing.Point(138, 74);
			this.resultBox.Name = "resultBox";
			this.resultBox.TabIndex = 7;
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(359, 121);
			this.Controls.Add(this.resultBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.calculateButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.value2Box);
			this.Controls.Add(this.operation);
			this.Controls.Add(this.value1Box);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox value1Box;
		private System.Windows.Forms.ComboBox operation;
		private System.Windows.Forms.TextBox value2Box;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button calculateButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox resultBox;
	}
}

