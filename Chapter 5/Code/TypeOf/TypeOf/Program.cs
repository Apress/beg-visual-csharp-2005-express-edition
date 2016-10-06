#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace TypeOfExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass someObject = new SomeClass();

            if (someObject.GetType() == typeof(SomeClass))
            {
                Console.WriteLine("We have a SomeClass object here");
            }

        }
    }

    class SomeClass
    {
    }
}
