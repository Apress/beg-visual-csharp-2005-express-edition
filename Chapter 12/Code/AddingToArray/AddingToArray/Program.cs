using System;
using System.Collections.Generic;
using System.Text;

namespace AddingToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static string[] AddStringToArray(string[] array, string newString)
        {
            string[] newArray = new string[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[newArray.Length] = newString;
            return newArray;
        }
    }
}
