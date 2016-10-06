#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace forloops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Currently at {0}", i);
            }
            Console.ReadLine();
        }
    }
}
