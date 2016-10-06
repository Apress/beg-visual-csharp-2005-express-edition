using System;
using System.Collections.Generic;
using System.Text;

namespace Comparers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> staff = new List<Employee>( new Employee[] {
                new Employee("Peter Wright", "IT"), 
                new Employee("Heather Wright", "Usability"), 
                new Employee("Dominic Shakeshaft", "Editorial"), 
                new Employee("Grace Wong", "Management"), 
                new Employee("Gary Cornell", "Management")
            });

            FindAnEmployee(staff, "Peter Wright");
            FindStaffInDepartment(staff, "Management");

            SortTheList(staff);

            Console.ReadLine();
        }

        private static void SortTheList(List<Employee> staff)
        {
            Console.WriteLine("The full list of sorted employees follows...");

            System.Comparison<Employee> comparer = CompareEmployees;
            staff.Sort(comparer);
            foreach (Employee emp in staff)
            {
                Console.WriteLine("\t{0}",emp.EmployeeName);
            }
        }

        private static int CompareEmployees(Employee firstEmployee, Employee secondEmployee)
        {
            string firstSurname = firstEmployee.EmployeeName.Substring(
                firstEmployee.EmployeeName.IndexOf(" ") + 1);
            string secondSurname = secondEmployee.EmployeeName.Substring(
                secondEmployee.EmployeeName.IndexOf(" ") + 1);
            return firstSurname.CompareTo(secondSurname);
        }

        private static Employee employeeToFind;

        private static void FindAnEmployee(List<Employee> staff, string name)
        {
            Console.WriteLine("Trying to find employee {0}", name);

       

            System.Predicate<Employee> searcher = FindEmployeeByNamePredicate;

            if (staff.Exists(delegate(Employee employeeToCheck)
            {
                return (employeeToCheck.EmployeeName.Equals(name));
            }))
            {
                Console.WriteLine("\tI found the employee in the list");

                Employee matchedEmployee = staff.Find(delegate(Employee employeeToCheck)
                {
                    return (employeeToCheck.EmployeeName.Equals(name));
                });

                Console.WriteLine("\t{0} works in {1}",
                    matchedEmployee.EmployeeName, matchedEmployee.Department);
            }
            else
            {
                Console.WriteLine("\tNo, I'm afraid I couldn't find the employee");
            }
        }
        static bool FindEmployeeByNamePredicate(Employee employeeToCheck)
        {
            return (employeeToCheck.EmployeeName.Equals(employeeToFind.EmployeeName));
        }

        private static void FindStaffInDepartment(List<Employee> staff, string department)
        {
            Console.WriteLine("Trying to find all staff that work in {0}", department);

            System.Predicate<Employee> searcher = FindEmployeesInDepartmentPredicate;

            List<Employee> matchedEmployees = staff.FindAll(delegate(Employee employeeToCheck)
            {
                return (employeeToCheck.Department.Equals(department));
            });
            foreach (Employee foundEmployee in matchedEmployees)
            {
                Console.WriteLine("\t{0} works in {1}",
                    foundEmployee.EmployeeName, foundEmployee.Department);
            }
        }

        static bool FindEmployeesInDepartmentPredicate(Employee employeeToCheck)
        {
            
        }
    }
}
