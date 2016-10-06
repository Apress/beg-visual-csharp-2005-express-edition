using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AddEditDelete
{
    public partial class EditDialog : Form
    {
        public EditDialog()
        {
            InitializeComponent();
        }

        private Employee _employee = null;
        public Employee StaffMember
        {
            get 
            {
                if (_employee == null)
                {
                    _employee = new Employee();
                }

                _employee.FirstName = firstName.Text;
                _employee.LastName = lastName.Text;
                _employee.JobTitle = jobTitle.Text;
                return _employee; 

            }
            set 
            { 
                _employee = value;
                firstName.Text = _employee.FirstName;
                lastName.Text = _employee.LastName;
                jobTitle.Text = _employee.JobTitle;
            }
        }
    }
}