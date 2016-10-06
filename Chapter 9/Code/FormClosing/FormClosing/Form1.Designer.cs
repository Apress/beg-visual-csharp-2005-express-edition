namespace FormClosing
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
            this.letFormCloseButton = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // letFormCloseButton
            // 
            this.letFormCloseButton.AutoSize = true;
            this.letFormCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letFormCloseButton.Location = new System.Drawing.Point(131, 88);
            this.letFormCloseButton.Name = "letFormCloseButton";
            this.letFormCloseButton.Size = new System.Drawing.Size(215, 28);
            this.letFormCloseButton.TabIndex = 0;
            this.letFormCloseButton.Text = "Allow this form to close";
            this.letFormCloseButton.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 218);
            this.Controls.Add(this.letFormCloseButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox letFormCloseButton;

    }
}

