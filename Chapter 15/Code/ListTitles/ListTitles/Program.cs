using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Xml;
using System.IO;


namespace XmlReaders
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            Stream rssFeedStream =
                client.OpenRead("http://blogs.apress.com/wp-rss2.php");

            XmlReader reader = XmlReader.Create(rssFeedStream);

            reader.MoveToContent();

            while (reader.ReadToFollowing("item"))
            {
                ProcessItem(reader.ReadSubtree());
            }

            Console.WriteLine("All done!");
            Console.ReadLine();

        }

        static void ProcessItem(XmlReader reader)
        {
            reader.ReadToFollowing("title");
            string title = reader.ReadElementContentAsString("title", reader.NamespaceURI);

            reader.ReadToFollowing("link");
            string link = reader.ReadElementContentAsString("link", reader.NamespaceURI);

            Console.WriteLine("{0}\n\t{1}", title, link);

        }
    }
}
