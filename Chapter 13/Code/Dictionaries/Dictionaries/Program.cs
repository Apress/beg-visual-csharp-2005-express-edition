using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> catalog =
                new Dictionary<string, Product>();

            SetupTheCatalog(catalog);

            try
            {
                Product foundProduct = catalog["WBS-SFTW-101"];
                if (foundProduct != null)
                {
                    Console.WriteLine("{0}: {1}\n\t{2}",
                        foundProduct.ProductID, foundProduct.ProductName, foundProduct.Description);
                }
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Couldn't find the product you asked for, sorry");
            }

            Console.ReadLine();
        }

        public static void SetupTheCatalog(Dictionary<string, Product> dict)
        {
            Product testProduct = new Product("WBS-SFTW-101", "CoolSoftware",
                "A neat piece of software");
            dict.Add(testProduct.ProductID.ToString(), testProduct);

            testProduct = new Product("WBS-SFTW-202", "NetSoftware",
                "A cool piece of Internet software");
            dict.Add(testProduct.ProductID.ToString(), testProduct);
        }
    }
}
