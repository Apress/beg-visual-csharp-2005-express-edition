using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MDIMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm child = new ChildForm();
            child.MdiParent = this;
            child.Show();
        }

  

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm formToSave = (ChildForm)this.ActiveMdiChild;
            formToSave.Save();
        }

        private void fileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
                saveToolStripMenuItem.Enabled = false;
            else
                saveToolStripMenuItem.Enabled = true;
        }
    }
}