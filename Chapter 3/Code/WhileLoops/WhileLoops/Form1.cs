#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace WhileLoops
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            DateTime endTime = DateTime.Now.AddSeconds(int.Parse(textBox1.Text));
            while (DateTime.Now < endTime)
            {
                listBox1.Items.Add(DateTime.Now.TimeOfDay.ToString());
            }
        }
    }
}