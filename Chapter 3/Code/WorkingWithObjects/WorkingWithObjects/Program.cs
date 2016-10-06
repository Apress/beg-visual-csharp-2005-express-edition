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
            int anInteger = 12;
            double aDouble = 12.34;
            float aFloatingPointNumber = 1.314512312F; // I know it's not Pi
            string name = "Pete";
            DateTime theTime = DateTime.Now;

            ShowMe(anInteger);
            ShowMe(aDouble);
            ShowMe(aFloatingPointNumber);
            ShowMe(name);
            ShowMe(theTime);

            Console.ReadLine();
        }

        static void ShowMe(object anObject)
        {
            Console.WriteLine(anObject.ToString());
        }

    }
}
