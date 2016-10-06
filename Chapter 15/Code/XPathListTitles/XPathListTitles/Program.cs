using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Net;

namespace XPathListTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string rssFeed = client.DownloadString("http://blogs.apress.com/wp-rss2.php");

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(rssFeed);

            XmlNodeList nodes = doc.SelectNodes("rss/channel/item/title");
            foreach (XmlNode node in nodes)
            {
                Console.WriteLine(node.InnerText);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
