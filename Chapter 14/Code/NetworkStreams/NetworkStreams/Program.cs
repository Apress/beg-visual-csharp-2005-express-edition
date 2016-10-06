using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace NetworkStreams
{
    class Program
    {
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(
            WebRequest.Create("http://www.apress.com")
                .GetResponse().GetResponseStream());


        
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
        Console.ReadLine();
    }
    }
}
