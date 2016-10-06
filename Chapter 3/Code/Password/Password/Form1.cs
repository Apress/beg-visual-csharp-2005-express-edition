#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Password
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( UserIsValid( password1.Text, password2.Text ))
            {
                MessageBox.Show("Congratulations - they match!");
            }
            else
            {
                MessageBox.Show("They don't match - try again.");
            }
        }

        private bool UserIsValid(string firstPassword, string secondPassword)
        {
            return (firstPassword == secondPassword);
        }
    }
}