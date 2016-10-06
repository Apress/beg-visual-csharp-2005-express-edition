#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace switcher
{
	partial class Form1: Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            switch (userType.Text.ToUpper())
            {
                case "MALE":
                    MessageBox.Show("So, you're a guy!");
                    break;
                case "FEMALE":
                    MessageBox.Show("Hello there m'lady.");
                    break;
                default:
                    MessageBox.Show("Help, help - an Alien");
                    break;
            }
        }    
	}
}