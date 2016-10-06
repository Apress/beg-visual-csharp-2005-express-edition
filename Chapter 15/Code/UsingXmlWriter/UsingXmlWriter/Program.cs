using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace UsingXmlWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            XmlWriter writer = XmlWriter.Create(@"C:\Test.xml", settings);

            writer.WriteStartDocument();

            writer.WriteStartElement("Customers");

            writer.WriteStartElement("Customer");

            writer.WriteAttributeString("ID", "1234");
            writer.WriteElementString("Address", "12 Somewhere Street, Sometown, 12354");

            writer.WriteEndElement();

            writer.WriteEndElement();

            writer.WriteEndDocument();

            writer.Flush();
            writer.Close();
        }
    }
}

