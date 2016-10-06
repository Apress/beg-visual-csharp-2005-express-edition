using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter(@"c:\myfile.txt");
            for (int i = 1; i < 11; i++)
            {
                writer.Write(i.ToString());
            }
            writer.Flush();
            writer.Close();

            foreach (string line in File.ReadAllLines(@"c:\myfile.txt"))
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}
