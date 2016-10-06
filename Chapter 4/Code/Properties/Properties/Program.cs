#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.SetName("Einstein", "Albert");

            Console.WriteLine("The person's full name is {0}",
                person.FullName);
            person.FullName = "John Wilkes Booth";

            Console.WriteLine("The person's full name is {0}",
                            person.FullName);


            Console.ReadLine();

        }
    }
}
