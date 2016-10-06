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

        private void okButton_Click(object sender, EventArgs e)
        {
            if (
                (usernameBox.Text == "apress") &&
                (passwordBox.Text == "noidea")
                )
            {
                MessageBox.Show("Welcome! You are now logged in.");
            }
            else
            {
                MessageBox.Show("Sorry, you didn't manage to log in.");
            }
        }
    }
}