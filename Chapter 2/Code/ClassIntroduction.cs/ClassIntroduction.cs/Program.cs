#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace ClassIntroduction_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog mac = new Dog();
            mac.Name = "Mac";
            mac.Breed = "Fluffy attack spaniel";

            Dog tosh = new Dog();
            tosh.Name = "Tosh";
            tosh.Breed = "Uber dumb muppet spaniel";

            mac.ShowInfo();
            tosh.ShowInfo();

            Console.ReadLine();
        }
    }

    class Dog
    {
        public string Name;
        public string Breed;

        public void ShowInfo()
        {
            Console.WriteLine("{0} is a {1}", Name, Breed);
        }
    }
}
