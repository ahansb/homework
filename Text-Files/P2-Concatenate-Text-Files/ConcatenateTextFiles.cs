//Problem 2. Concatenate text files
//Write a program that concatenates two text files into another text file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class ConcatenateTextFiles
    {
        static void Main()
        {
            var srOne = new StreamReader(@"..\..\TextFile1.txt");
            var srTwo = new StreamReader(@"..\..\TextFile2.txt");
            var sw = new StreamWriter(@"..\..\Concat.txt");
            using (srOne)
            {
                string line = srOne.ReadLine();
                while (line!=null)
                {
                    sw.WriteLine(line);
                    line = srOne.ReadLine();
                }
            }
            using (srTwo)
            {
                string line = srTwo.ReadLine();
                while (line != null)
                {
                    sw.WriteLine(line);
                    line = srTwo.ReadLine();
                }
            }
            
            sw.Close();
            Console.WriteLine("Done");
        }
    }