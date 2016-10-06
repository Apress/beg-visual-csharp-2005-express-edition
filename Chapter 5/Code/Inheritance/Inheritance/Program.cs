#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car aCar = (Car)new OffRoader();
            aCar.Drive();
            aCar.Stop();

            Console.ReadLine();
        }
    }
}
