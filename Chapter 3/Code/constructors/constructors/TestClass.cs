#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace ConsoleApplication1
{
    public class TestClass
    {
        public TestClass()
        {
            Console.WriteLine("TestClass just got instantiated");
        }

        public TestClass(string name)
        {
            Console.WriteLine("TestClass was instantiated by {0}", name);
        }

        ~TestClass()
        {
            Console.WriteLine("TestClass object just died");
        }
    }
}
