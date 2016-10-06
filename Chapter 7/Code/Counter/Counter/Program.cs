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
            int start = 0;
            CountTo100(start, 100);
            Console.ReadLine();
        }
        private static void CountTo100(int start, int end)
        {

            for (int i = start; i < end; i++)
            {
                Console.WriteLine("i is now {0}", i);
            }
        }
    }
}
