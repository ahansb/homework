//Problem 9. Delete odd lines
//    Write a program that deletes from given text file all odd lines.
//    The result should be in the same file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class DeleteOddLines
    {
        static void Main()
        {
            var sr = new StreamReader(@"..\..\TextFile.txt");
            
            var list = new List<string>();
            using (sr)
            {
                string line = sr.ReadLine();
                int countLine = 1;
                while (line != null)
                {
                    if (!(countLine%2==0))
                    {
                        list.Add(line);
                    }
                    ++countLine;
                    line = sr.ReadLine();
                }
            }
            var sw = new StreamWriter(@"..\..\TextFile.txt");
            using (sw)
            {
                foreach (var line in list)
                {
                    sw.WriteLine(line);
                }
            }
            Console.WriteLine("DONE");
        }
    }