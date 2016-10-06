namespace DateTimePicker
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Button addButton;
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.specialDate = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 13);
            label1.TabIndex = 2;
            label1.Text = "Pick a date to add";
            // 
            // addButton
            // 
            addButton.Location = new System.Drawing.Point(289, 9);
            addButton.Name = "addButton";
            addButton.Size = new System.Drawing.Size(75, 23);
            addButton.TabIndex = 3;
            addButton.Text = "Add";
            addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.CalendarDimensions = new System.Drawing.Size(3, 3);
            this.monthCalendar.Location = new System.Drawing.Point(18, 74);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.Size = new System.Drawing.Size(542, 439);
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // specialDate
            // 
            this.specialDate.Location = new System.Drawing.Point(108, 12);
            this.specialDate.Name = "specialDate";
            this.specialDate.Size = new System.Drawing.Size(175, 20);
            this.specialDate.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 529);
            this.Controls.Add(addButton);
            this.Controls.Add(label1);
            this.Controls.Add(this.specialDate);
            this.Controls.Add(this.monthCalendar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.DateTimePicker specialDate;
    }
}

