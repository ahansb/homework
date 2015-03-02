//Problem 7. Replace sub-string
//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class ReplaceSubstring
{
    static void Main()
    {
        var sr = new StreamReader(@"..\..\TextFile1.txt");

        var sw = new StreamWriter(@"..\..\replaced.txt");
        using (sr)
        {
            string line = sr.ReadLine();
            
            while (line != null)
            {
                line = line.Replace("start", "finish");
                
                sw.WriteLine(line);
                line = sr.ReadLine();
                
            }
        }

        sw.Close();
        Console.WriteLine("Done");
    }
}