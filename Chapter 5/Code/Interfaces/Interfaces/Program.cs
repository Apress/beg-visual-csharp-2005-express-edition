#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar myCar = (ICar)new Offroader();
            myCar.Drive();
        }
    }
}
