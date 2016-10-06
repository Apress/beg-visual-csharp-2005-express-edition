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
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Counting up: {0}", x);
            }
            for (int y = 10; y > 0; y--)
            {
                Console.WriteLine("Counting down: {0}", y);
            }
            Console.ReadLine();
        }
    }
}
