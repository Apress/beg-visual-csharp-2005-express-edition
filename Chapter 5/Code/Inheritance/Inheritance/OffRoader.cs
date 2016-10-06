#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Inheritance
{
    public class OffRoader : Car
    {
        public OffRoader()
        {

        }


        public override void Drive()
        {
            Console.WriteLine("The passengers turn green as you zoom down a rocky valley");
        }


    }
}
