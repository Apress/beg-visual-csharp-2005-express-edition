using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OpeningAndClosingWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        SecondWindow newWindow= null;
        private void openButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                newWindow = new SecondWindow();
                newWindow.Show();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 2)
            {
                newWindow.Close();
                newWindow = null;
            }
        }
    }
}