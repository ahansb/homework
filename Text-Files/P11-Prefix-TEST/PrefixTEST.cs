//Problem 11. Prefix "test"
//    Write a program that deletes from a text file all words that start with the prefix test.
//    Words contain only the symbols 0…9, a…z, A…Z, _.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class PrefixTEST
    {
        static void Main()
        {
            var sr = new StreamReader(@"..\..\TextFile1.txt");

            var sw = new StreamWriter(@"..\..\replaced.txt");


            DeletePrefix(sr,sw,"test");


        }

        private static void DeletePrefix(StreamReader sr, StreamWriter sw, string pref)
        {
            
            using (sr)
            {
                string line = sr.ReadLine();

                while (line != null)
                {
                    line = line.Replace(pref, "");

                    sw.WriteLine(line);
                    line = sr.ReadLine();

                }
            }

            sw.Close();
            Console.WriteLine("Done");
        }
    }