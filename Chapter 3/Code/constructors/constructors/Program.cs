#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("About to create an instance of TestClass");
            TestClass newClass = new TestClass();

            TestClass anotherClass = new TestClass("C# Express");

            Console.WriteLine("All done!");
            Console.ReadLine();
        }
    }
}
