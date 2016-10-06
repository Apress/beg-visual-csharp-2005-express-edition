using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void calculateButton_Click(object sender, EventArgs e)
		{
			double value1 = Double.Parse(value1Box.Text);
			double value2 = Double.Parse(value2Box.Text);
			double result = 0.0;


			Calculator calc = new Calculator();

			switch (operation.Text)
			{
				case "Add":
					result = calc.Add(value1, value2);
					break;
				case "Subtract":
					result = calc.Subtract(value1, value2);
					break;
				case "Multiply":
					result = calc.Multiply(value1, value2);
					break;
				case "Divide":
					result = calc.Divide(value1, value2);
					break;
			}

           
        }
	}
}