using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<ProductNumber, Product> catalog =
                new Dictionary<ProductNumber, Product>();

            SetupTheCatalog(catalog);

            try
            {
                ProductNumber numToFind = new ProductNumber("WBS-SFTW-202");
                if (catalog.ContainsKey(new ProductNumber("WBS-SFTW-202")))
                    Console.WriteLine("Apparently, the product does exist");
                else
                    Console.WriteLine("ContainsKey fails");
                Product foundProduct = catalog[numToFind];
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

        public static void SetupTheCatalog(Dictionary<ProductNumber, Product> dict)
        {
            Product testProduct = new Product("WBS-SFTW-101"
                , "CoolSoftware",
                "A neat piece of software");
            dict.Add(testProduct.ProductID, testProduct);

            testProduct = new Product("WBS-SFTW-202"
                , "NetSoftware",
                "A cool piece of Internet software");
            dict.Add(testProduct.ProductID, testProduct);
        }
    }
}
