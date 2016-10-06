#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace FailingDivision
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            string result = "";

            try
            {
                double dividend = Double.Parse(dividendBox.Text);
                double divisor = Double.Parse(divisorBox.Text);

                result = (dividend / divisor).ToString();
            }
//            catch (FormatException formatEx)
//            {
//                MessageBox.Show("You have to enter numbers into the boxes, not text");
//            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong : " + ex.Message);
            }
            finally
            {
                resultBox.Text = result;
            }
        }
    }
}