using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee pete = new Employee();
            Employee fred = new Employee();

            pete.Hire += new HRActionDelegate(NewEmployee);
            fred.Hire += new HRActionDelegate(NewEmployee);
            pete.Fire += new HRActionDelegate(RetireEmployee);
            fred.Fire += new HRActionDelegate(RetireEmployee);

            Console.WriteLine("Let the hiring and firing commence...");
            pete.HireEmployee("Pete");
            fred.HireEmployee("Fred");
            pete.FireEmployee();
            fred.FireEmployee();
            Console.ReadLine();
        }

        public static void NewEmployee(string name)
        {
            Console.WriteLine("We just hired {0}", name);
        }

        public static void RetireEmployee(string name)
        {
            Console.WriteLine("{0} just took early retirement", name);
        }
    }


    class Employee
    {
        public event HRActionDelegate Hire;
        public event HRActionDelegate Fire;
        private string _employeeName;

        public void HireEmployee(string name)
        {
            _employeeName = name;
            if (Hire != null)
                Hire(_employeeName);
        }

        public void FireEmployee()
        {
            if (Fire != null)
                Fire(_employeeName);
        }
    }


    public delegate void HRActionDelegate( string name );

}
