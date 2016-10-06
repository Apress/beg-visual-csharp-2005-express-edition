using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ReadandWritewiththeFileclass
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = new string[10];
            for (int i = 0; i < 10; i++)
            {
                lines[i] = String.Format(
                    "This is line number {0}", i
                    );
            }

            if (File.Exists(@"c:\test.txt"))
                File.Delete(@"c:\test.txt");

            File.WriteAllLines(@"c:\test.txt", lines);

            foreach (string line in
                File.ReadAllLines(@"c:\test.txt"))
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();
        }
    }
}
