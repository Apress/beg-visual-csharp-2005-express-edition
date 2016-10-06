namespace MDIApplication
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
            this.newWindowButton = new System.Windows.Forms.Button();
            this.cascadeButton = new System.Windows.Forms.Button();
            this.tileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newWindowButton
            // 
            this.newWindowButton.Location = new System.Drawing.Point(-1, -4);
            this.newWindowButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newWindowButton.Name = "newWindowButton";
            this.newWindowButton.Size = new System.Drawing.Size(100, 28);
            this.newWindowButton.TabIndex = 1;
            this.newWindowButton.Text = "New Window";
            this.newWindowButton.Click += new System.EventHandler(this.newWindowButton_Click);
            // 
            // cascadeButton
            // 
            this.cascadeButton.Location = new System.Drawing.Point(-1, 32);
            this.cascadeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cascadeButton.Name = "cascadeButton";
            this.cascadeButton.Size = new System.Drawing.Size(100, 28);
            this.cascadeButton.TabIndex = 3;
            this.cascadeButton.Text = "Cascade";
            this.cascadeButton.Click += new System.EventHandler(this.cascadeButton_Click);
            // 
            // tileButton
            // 
            this.tileButton.Location = new System.Drawing.Point(-1, 68);
            this.tileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tileButton.Name = "tileButton";
            this.tileButton.Size = new System.Drawing.Size(100, 28);
            this.tileButton.TabIndex = 4;
            this.tileButton.Text = "Tile";
            this.tileButton.Click += new System.EventHandler(this.tileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 463);
            this.Controls.Add(this.tileButton);
            this.Controls.Add(this.cascadeButton);
            this.Controls.Add(this.newWindowButton);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newWindowButton;
        private System.Windows.Forms.Button cascadeButton;
        private System.Windows.Forms.Button tileButton;

    }
}

