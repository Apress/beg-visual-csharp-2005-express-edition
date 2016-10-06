namespace MDIMenu
{
    partial class ChildForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.specialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settoRedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settoBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settoGreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.specialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // specialToolStripMenuItem
            // 
            this.specialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settoRedToolStripMenuItem,
            this.settoBlueToolStripMenuItem,
            this.settoGreenToolStripMenuItem});
            this.specialToolStripMenuItem.Name = "specialToolStripMenuItem";
            this.specialToolStripMenuItem.Text = "&Special";
            // 
            // settoRedToolStripMenuItem
            // 
            this.settoRedToolStripMenuItem.Image = MDIMenu.Properties.Resources.Flag_red;
            this.settoRedToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settoRedToolStripMenuItem.Name = "settoRedToolStripMenuItem";
            this.settoRedToolStripMenuItem.Text = "Set to Red";
            this.settoRedToolStripMenuItem.Click += new System.EventHandler(this.settoRedToolStripMenuItem_Click);
            // 
            // settoBlueToolStripMenuItem
            // 
            this.settoBlueToolStripMenuItem.Image = MDIMenu.Properties.Resources.Flag_blue;
            this.settoBlueToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settoBlueToolStripMenuItem.Name = "settoBlueToolStripMenuItem";
            this.settoBlueToolStripMenuItem.Text = "Set to Blue";
            this.settoBlueToolStripMenuItem.Click += new System.EventHandler(this.settoBlueToolStripMenuItem_Click);
            // 
            // settoGreenToolStripMenuItem
            // 
            this.settoGreenToolStripMenuItem.Image = MDIMenu.Properties.Resources.Flag_green;
            this.settoGreenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settoGreenToolStripMenuItem.Name = "settoGreenToolStripMenuItem";
            this.settoGreenToolStripMenuItem.Text = "Set to Green";
            this.settoGreenToolStripMenuItem.Click += new System.EventHandler(this.settoGreenToolStripMenuItem_Click);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 541);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.menuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem specialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settoRedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settoBlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settoGreenToolStripMenuItem;
    }
}