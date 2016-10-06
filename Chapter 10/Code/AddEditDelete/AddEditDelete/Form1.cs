using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AddEditDelete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            EditDialog newEmployeeDialog = new EditDialog();
            if (newEmployeeDialog.ShowDialog() == DialogResult.OK)
            {
                employeeList.Items.Add(newEmployeeDialog.StaffMember);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (employeeList.SelectedIndex == -1)
                return;
            
            int employeeNum = employeeList.SelectedIndex;
            EditDialog newEmployeeDialog = new EditDialog();
            newEmployeeDialog.StaffMember =
                (Employee) employeeList.SelectedItem;

            if (newEmployeeDialog.ShowDialog() == DialogResult.OK)
            {
                employeeList.Items.RemoveAt(employeeNum);
                employeeList.Items.Insert(employeeNum,
                    newEmployeeDialog.StaffMember);
                employeeList.SelectedIndex = employeeNum;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (employeeList.SelectedIndex == -1)
                return;

            if (MessageBox.Show("Really delete this employee",
                "Delete", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                employeeList.Items.Remove(
                    employeeList.SelectedItem);
            }
        }

        private void employeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (employeeList.SelectedIndex != -1)
            {
                Employee currentEmployee = (Employee)employeeList.SelectedItem;
                firstName.Text = currentEmployee.FirstName;
                lastName.Text = currentEmployee.LastName;
                jobTitle.Text = currentEmployee.JobTitle;
            }
            else
            {
                firstName.Text = lastName.Text = jobTitle.Text = "";
            }
        }

        

    }
}