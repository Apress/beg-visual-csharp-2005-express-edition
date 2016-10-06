#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Inheritance
{
    public class Car
    {
        public Car() 
        {
        }

        public virtual void Drive()
        {
            Console.WriteLine("We're now whizzing along the road");
        }
        public void Stop()
        {
            Console.WriteLine("The car comes to a screeching stop");
        }
    }
}
