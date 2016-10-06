using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Timers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            allNumbersTimer.Enabled = !allNumbersTimer.Enabled;
            evenNumbersTimer.Enabled = !evenNumbersTimer.Enabled;
        }

       
        private int _evenNumbers = 0;
        private void evenNumbersTimer_Tick(object sender, EventArgs e)
        {
            _evenNumbers += 2;
            evenNumbers.Items.Add(_evenNumbers);
        }
        
        private int _num = 0;
        private void allNumbersTimer_Tick(object sender, EventArgs e)
        {
            _num++;
            allNumbers.Items.Add(_num);
        }
    }
}