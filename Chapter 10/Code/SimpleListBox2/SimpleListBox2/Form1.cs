using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                listBox1.Items.Add(string.Format("Item number {0} of 50", i));
            }

            for (int j = 0; j < 100000; j++)
            {
                listBox2.Items.Add(string.Format("This is item {0} of 100,000", j));
            }
        }
    }
}