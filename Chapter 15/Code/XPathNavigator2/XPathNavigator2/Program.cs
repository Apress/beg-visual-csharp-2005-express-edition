using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.XPath;


namespace XPathNavigator2
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
            XPathNodeIterator nodes = 
                nav.Select("/Order/Item[Price>10]/Description");

            while (nodes.MoveNext())
            {
                Console.WriteLine("Item {0} has a price greater than 10",
                    nodes.Current.Value);
            }

            Console.ReadLine();
        }
    }
}
