#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace TypeEval
{
    class Program
    {
        static void Main(string[] args)
        {
            Director myDirector = new Director();
            Employee myEmployee = (Employee)myDirector;

            DoSomething(myEmployee);
            DoSomething(myDirector);

            Console.ReadLine();
        }

        static void DoSomething(Employee emp)
        {
            Console.WriteLine("Doing something to an employee");
            emp.ShowDetails() ;
        }

        static void DoSomething(Director dir)
        {
            Console.WriteLine("Doing something to a director");
            dir.ShowDetails();
        }
    }

    class Employee
    {
        public virtual void ShowDetails()
        {
            Console.WriteLine("I am an employee");
        }
    }

    class Director : Employee
    {
        public override void ShowDetails()
        {
            Console.WriteLine("I am a director");
        }
    }
}
