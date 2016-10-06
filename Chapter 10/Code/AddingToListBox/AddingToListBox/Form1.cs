using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AddingToListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // HACK to work around C# Express Beta 2 bug with empty lists
            if (( demoListBox.Items.Count == 1 )  && 
                (demoListBox.Items[0].ToString().Length == 0 ) )
            demoListBox.Items.Clear();
            // END HACK
            demoListBox.Items.Add(newItemBox.Text);
            newItemBox.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }
    }
}