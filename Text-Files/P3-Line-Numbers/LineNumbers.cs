//Problem 3. Line numbers
//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class LineNumbers
    {
        static void Main()
        {
            var sr = new StreamReader(@"..\..\TextFile1.txt");
            
            var sw = new StreamWriter(@"..\..\numbered.txt");
            using (sr)
            {
                string line = sr.ReadLine();
                int num = 1;
                while (line != null)
                {
                    sw.Write("{0:D2}. ",num);
                    sw.WriteLine(line);
                    line = sr.ReadLine();
                    ++num;
                }
            }
            
            sw.Close();
            Console.WriteLine("Done");
        }
    }