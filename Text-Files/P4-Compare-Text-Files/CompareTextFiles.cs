//Problem 4. Compare text files
//Write a program that compares two text files line by line and prints the number of 
//lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

using System;
using System.IO;
class CompareTextFiles
    {
        static void Main()
        {
            var srOne = new StreamReader(@"..\..\TextFile1.txt");
            var srTwo = new StreamReader(@"..\..\TextFile2.txt");
            
            using (srOne)
            {
                string lineOne = srOne.ReadLine();
                string lineTwo = srTwo.ReadLine();
                int countSame = 0;
                int countDiff = 0;
                while (lineOne != null)
                {
                    if (lineOne == lineTwo)
                    {
                        ++countSame;
                    }
                    else
                    {
                        ++countDiff;
                    }
                    lineOne = srOne.ReadLine();
                    lineTwo = srTwo.ReadLine();
                }
                Console.WriteLine("Same are {0} lines", countSame);
                Console.WriteLine("Different are {0} lines", countDiff);
            }
            
        }
    }