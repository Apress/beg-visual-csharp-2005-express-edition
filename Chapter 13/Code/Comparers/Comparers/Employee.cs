using System;
using System.Collections.Generic;
using System.Text;

namespace Comparers
{
    class Employee
    {
        private int _employeeNumber;
        public string EmployeeName;
        public string Department;

        public int EmployeeNumber
        {
            get { return _employeeNumber; }
        }

        public Employee(string name, string department)
        {
            EmployeeName = name;
            Department = department;
            _employeeNumber = new Random().Next();
        }

        public Employee()
        {
            // The standard do nothing constructor.
        }
    }
}
