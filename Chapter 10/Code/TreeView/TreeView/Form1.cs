using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            treeView1.Nodes.Clear();

            TreeNode evenNumbers = treeView1.Nodes.Add("Even Numbers");
            TreeNode oddNumbers =  treeView1.Nodes.Add("Odd Numbers");

            for (int i = 1; i < 500; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers.Nodes.Add(i.ToString());
                } else {
                    oddNumbers.Nodes.Add(i.ToString() );
                }
            }
        }
    }
}