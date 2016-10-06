using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace XPathNavigationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string xml = "<Order>" +
                            "<Item>" +
                                "<Description>Some widget part</Description>" +
                                "<Price>12.99</Price>" +
                            "</Item>" +
                            "<Item>" +
                                "<Description>Another widget</Description>" +
                                "<Price>50.12</Price>" +
                            "</Item>" +
                        "</Order>";

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            XPathNavigator nav = doc.CreateNavigator();
            Console.WriteLine("Total price for this order is ${0}", 
                nav.Evaluate("sum(Order/Item/Price)"));

            Console.ReadLine();
        }
    }
}
