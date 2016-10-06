using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            System.DateTime[] boldDates = new System.DateTime[monthCalendar.BoldedDates.Length + 1];
            int i =0;
            foreach (DateTime currentDate in monthCalendar.BoldedDates)
            {
                boldDates[i] = currentDate;
                i++;
            }
            boldDates[i] = System.DateTime.Parse(specialDate.Text);
            monthCalendar.BoldedDates = boldDates;
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            specialDate.Text = e.Start.ToLongDateString();
        }
    }
}