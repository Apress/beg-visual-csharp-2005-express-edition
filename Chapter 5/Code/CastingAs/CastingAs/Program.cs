#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CastingAs
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat digit = new Cat();
            dog mac = new dog();

            DoSomething(digit);
            DoSomething(mac);

            Console.ReadLine();
        }

        public static void DoSomething( Object pet )
        {
            Cat petCat = pet as Cat;
            if ( petCat != null ) 
            {
                Console.WriteLine("The pet is a cat");
            } else {
                Console.WriteLine("The pet is a dog");
            }
        }
    }

    class Cat
    {
        
    }

    class dog
    {

    }
}
