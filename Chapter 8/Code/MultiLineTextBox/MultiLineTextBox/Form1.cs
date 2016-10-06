using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MultiLineTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showLinesButton_Click(object sender, EventArgs e)
        {
            StringBuilder lineInfo = new StringBuilder();
            lineInfo.Append("There are " + multiLineBox.Lines.Length.ToString() + " lines.\n");
            foreach (string line in multiLineBox.Lines)
            {
                lineInfo.Append(line + "\n");
            }

            MessageBox.Show(lineInfo.ToString());
        }
    }
}