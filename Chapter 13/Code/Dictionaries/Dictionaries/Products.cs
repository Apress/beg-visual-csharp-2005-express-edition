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

        public  Product(string productCode, string name, string description)
        {
            _productID = new ProductNumber(productCode);
            ProductName = name;
            Description = description;
        }
    }

    struct ProductNumber
    {
        string ManufacturerCode;
        string CategoryCode;
        int Number;

        public  ProductNumber(string code)
        {
            string[] codeParts = code.Split(new char[] { '-' });
            ManufacturerCode = codeParts[0];
            CategoryCode = codeParts[1];
            Number = int.Parse(codeParts[2]);
        }

        public override string  ToString()
        {
 	        return string.Format("{0}-{1}-{2}", 
                ManufacturerCode, CategoryCode, Number );
        }
    }
}
