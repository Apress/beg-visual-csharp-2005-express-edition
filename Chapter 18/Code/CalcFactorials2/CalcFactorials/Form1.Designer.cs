namespace CalcFactorials
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
            this.startingNumber = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.resultsBox = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting number";
            // 
            // startingNumber
            // 
            this.startingNumber.Location = new System.Drawing.Point(124, 15);
            this.startingNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startingNumber.Name = "startingNumber";
            this.startingNumber.Size = new System.Drawing.Size(132, 22);
            this.startingNumber.TabIndex = 1;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(265, 12);
            this.calcButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(100, 28);
            this.calcButton.TabIndex = 2;
            this.calcButton.Text = "Calculate";
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // resultsBox
            // 
            this.resultsBox.FormattingEnabled = true;
            this.resultsBox.ItemHeight = 16;
            this.resultsBox.Location = new System.Drawing.Point(17, 47);
            this.resultsBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(347, 260);
            this.resultsBox.TabIndex = 3;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 327);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.startingNumber);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox startingNumber;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.ListBox resultsBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

