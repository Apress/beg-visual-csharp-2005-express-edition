using System;
using System.Collections.Generic;
using System.Text;

namespace ContainsProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> staff = new List<Employee>();

            Employee newHire = new Employee("John Smith", "1101");
            staff.Add(newHire);

            if (staff.Contains(newHire))
                Console.WriteLine("Yes the list contains the item we just added\n\t{0}",
                    newHire.ToString());

            newHire = new Employee("John Smith", "1101");
            if (staff.Contains(newHire))
                Console.WriteLine("The list also contains {0}");
            else
                Console.WriteLine("Nope, can't find John Smith");

            Console.ReadLine();
        }
    }

    class Employee
    {
        public string Name;
        public string Number;
        private int _id;

        public Employee(string name, string number)
        {
            this.Name = name;
            this.Number = number;
            _id = new Random().Next(10000);
        }

        public override string ToString()
        {
            return string.Format("Employee num: {0}  Name: {1} (id {2})",
                this.Number, this.Name, _id);

        }
    }
}
