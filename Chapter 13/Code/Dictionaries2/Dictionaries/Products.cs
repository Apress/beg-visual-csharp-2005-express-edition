using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionaries
{
    class Product
    {
        private ProductNumber _productID;
        public ProductNumber ProductID
        {
            get { return _productID; }
        }

        public string ProductName;
        public string Description;

        public Product(string productCode, string name, string description)
        {
            _productID = new ProductNumber(productCode);
            ProductName = name;
            Description = description;
        }
    }

    public struct ProductNumber
    {
        public string ManufacturerCode;
        public string CategoryCode;
        public int Number;

        public ProductNumber(string code)
        {
            string[] codeParts = code.Split(new char[] { '-' });
            ManufacturerCode = codeParts[0];
            CategoryCode = codeParts[1];
            Number = int.Parse(codeParts[2]);
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}",
                ManufacturerCode, CategoryCode, Number);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is ProductNumber))
                throw new InvalidCastException("Can only compare a ProductNumber to another ProductNumber");
            return this.ToString().Equals(obj.ToString());
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }

    class PrintSomethingClass<T>
    {
        private T _value;
        public PrintSomethingClass(T valueToStore)
        {
            _value = valueToStore;
        }

        public void PrintTheValue()
        {
            Console.WriteLine("{0}", _value );
        }
    }

}
