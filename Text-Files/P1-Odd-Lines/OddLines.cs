//Problem 1. Odd lines
//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;
using System.Text;

class OddLines
{
    static void Main()
    {
        var sr = new StreamReader(@"..\..\TextFile.txt");
        using (sr)
        {
            string line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine("{0}", sr.ReadLine());
                line = sr.ReadLine();
            }
        }
    }
}