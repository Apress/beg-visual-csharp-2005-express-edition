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
            string[] names = { "Pete", "John", "Dave", "Gary" };

            Console.WriteLine("The array contains {0} elements.", names.Length);

            int index = 0;

            foreach (string name in names)
            {
                Console.WriteLine("Names[{0}] = {1}", index, name);
                index++;
            }

            Console.ReadLine();

        }


    }
}
