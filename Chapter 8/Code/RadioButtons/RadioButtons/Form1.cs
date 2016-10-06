using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RadioButtons
{
    public partial class Form1 : Form
    {
        string ticketClass;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have requested a seat in the " +
                ticketClass + " section of the aircraft");
        }

        private void TicketTypeChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            if (button.Checked)
                ticketClass = button.Text;
        }
    }
}