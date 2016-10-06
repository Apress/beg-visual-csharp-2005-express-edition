#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Division
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int divisor = int.Parse(divisorBox.Text);
            int dividend = int.Parse(dividendBox.Text);

            int result = divisor / dividend;
            int modulus = divisor % dividend;

            MessageBox.Show("The answer is " +
                result.ToString() +
                " with " +
                modulus.ToString() +
                " left over.");


        }
    }
}