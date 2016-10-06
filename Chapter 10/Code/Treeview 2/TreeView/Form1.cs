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
            treeView1.ShowNodeToolTips = true;

            TreeNode evenNumbers = treeView1.Nodes.Add(
                "Even", "Even Numbers", 0,1);
            evenNumbers.BackColor = Color.Blue;
            evenNumbers.ForeColor = Color.Yellow;
            evenNumbers.ToolTipText = "The even numbers";

            TreeNode oddNumbers =  treeView1.Nodes.Add(
                "Odd", "Odd Numbers", 0,1);
            oddNumbers.BackColor = Color.Yellow;
            oddNumbers.ForeColor = Color.Blue;
            oddNumbers.ToolTipText = "The odd numbers";

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

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            if (selectedNode.Nodes.ContainsKey("PrimeNumber"))
            {
                Console.WriteLine("This node contains prime numbers");
            }
        }
    }
}