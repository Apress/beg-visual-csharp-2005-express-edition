#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace WindowsApplication1
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Text = "The mouse is over me";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Text = "The mouse is not over me";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                clickedButton.Text = "I was clicked";
            }
        }
    }
}