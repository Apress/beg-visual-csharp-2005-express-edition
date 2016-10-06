#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            OffRoader jeep = new OffRoader();
            Sedan ford = new Sedan();

            DescribeCar(jeep);
            DescribeCar(ford);

            Console.ReadLine();
        }

        static void DescribeCar(Car theCar)
        {
            theCar.Describe();
        }
    }
}
