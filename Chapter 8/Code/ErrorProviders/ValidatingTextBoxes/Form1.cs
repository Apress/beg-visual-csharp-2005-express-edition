using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ValidatingTextBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numberBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int numberEntered = int.Parse(numberBox.Text);
                if (numberEntered < 1 || numberEntered > 10)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(numberBox, 
                        "You must enter a number between 1 and 10");
                }
            }
            catch (FormatException)
            {
                e.Cancel = true;
                errorProvider1.SetError(numberBox, 
                    "You need to enter a whole number");
            }
        }

        private void numberBox_Validated(object sender, EventArgs e)
        {
            MessageBox.Show("Well done, you managed to enter a valid number");
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numberBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}