#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Interfaces
{
    interface ICar
    {
         void Start();
         void Stop();
         void Drive();
    }

    partial class Offroader : ICar
    {
 
    }
}
