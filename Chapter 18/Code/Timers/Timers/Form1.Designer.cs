namespace Timers
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
            this.components = new System.ComponentModel.Container();
            this.allNumbersTimer = new System.Windows.Forms.Timer(this.components);
            this.allNumbers = new System.Windows.Forms.ListBox();
            this.evenNumbers = new System.Windows.Forms.ListBox();
            this.startButton = new System.Windows.Forms.Button();
            this.evenNumbersTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // allNumbersTimer
            // 
            this.allNumbersTimer.Interval = 500;
            this.allNumbersTimer.Tick += new System.EventHandler(this.allNumbersTimer_Tick);
            // 
            // allNumbers
            // 
            this.allNumbers.FormattingEnabled = true;
            this.allNumbers.ItemHeight = 16;
            this.allNumbers.Location = new System.Drawing.Point(16, 15);
            this.allNumbers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allNumbers.Name = "allNumbers";
            this.allNumbers.Size = new System.Drawing.Size(172, 228);
            this.allNumbers.TabIndex = 0;
            // 
            // evenNumbers
            // 
            this.evenNumbers.FormattingEnabled = true;
            this.evenNumbers.ItemHeight = 16;
            this.evenNumbers.Location = new System.Drawing.Point(197, 15);
            this.evenNumbers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.evenNumbers.Name = "evenNumbers";
            this.evenNumbers.Size = new System.Drawing.Size(172, 228);
            this.evenNumbers.TabIndex = 1;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(271, 251);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 28);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // evenNumbersTimer
            // 
            this.evenNumbersTimer.Interval = 800;
            this.evenNumbersTimer.Tick += new System.EventHandler(this.evenNumbersTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 294);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.evenNumbers);
            this.Controls.Add(this.allNumbers);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer allNumbersTimer;
        private System.Windows.Forms.ListBox allNumbers;
        private System.Windows.Forms.ListBox evenNumbers;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer evenNumbersTimer;
    }
}

