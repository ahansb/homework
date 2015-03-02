//Problem 6. Save sorted names
//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

using System;
using System.Text;
using System.IO;
using System.Collections.Generic;


class SaveSortedNames
{
    static void Main()
    {
        var sr = new StreamReader(@"..\..\TextFile1.txt");

        var sw = new StreamWriter(@"..\..\Sorted.txt");
        var names = new List<string>();
        using (sr)
        {
            string line = sr.ReadLine();
            
            while (line != null)
            {
                names.Add(line);
                line = sr.ReadLine();
                
            }
            
            names.Sort();
        }
        using (sw)
        {
            foreach (var name in names)
            {
                sw.WriteLine(name);
            }
        }
        
        Console.WriteLine("Done");
    }
}