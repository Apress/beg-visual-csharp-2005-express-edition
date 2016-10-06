#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace TextBoxSelections
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (inputBox.SelectionLength == 0)
            {
                MessageBox.Show("You need to select something inside the text box first");
            }
            else
            {
                System.Text.StringBuilder builder = new System.Text.StringBuilder();
                builder.Append(String.Format("The input box contains {0}\n", inputBox.Text));
                builder.Append(String.Format("You have selected {0} characters, starting at {1}\n",
                    inputBox.SelectionLength, inputBox.SelectionStart));
                builder.Append(String.Format("The selection is {0}", inputBox.SelectedText));

                MessageBox.Show(builder.ToString());

            }
        }
    }
}