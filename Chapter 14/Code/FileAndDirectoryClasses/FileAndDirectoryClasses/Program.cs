using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileAndDirectoryClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(@"c:\");
            foreach (string filename in Directory.GetFiles(@"c:\"))
            {
                FileInfo file = new FileInfo(filename);
                Console.WriteLine(
                    "{0} created on {1}, and is a {2} file",
                    file.Name, file.CreationTime, 
                    file.Extension);
            }
            Console.ReadLine();
        }
    }
}
