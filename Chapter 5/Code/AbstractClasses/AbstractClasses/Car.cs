#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace AbstractClasses
{
    public abstract class Car
    {
        public abstract void Describe();
    }

    public class OffRoader : Car  
    {
        public override void Describe()
        {
            Console.WriteLine("Big, boxy, with big wheels and a big engine");
        }
    }

    public class Sedan : Car
    {
        public override void Describe()
        {
            Console.WriteLine("Just your average ordinary family car");
        }
    }
}
