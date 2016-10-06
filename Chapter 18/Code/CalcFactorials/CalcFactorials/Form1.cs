using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalcFactorials
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            resultsBox.Items.Clear();
            long startingNum = long.Parse(startingNumber.Text);

            for (long currentNum = startingNum;
                currentNum < startingNum + 1000;
                currentNum++)
            {
                long factorial = 0;
                for (long i = 1; i < currentNum; i++)
                {
                    factorial += i;
                }

                resultsBox.Items.Add(
                    string.Format("The factorial of {0} is {1}",
                    currentNum, factorial));
            }
        }
    }
}