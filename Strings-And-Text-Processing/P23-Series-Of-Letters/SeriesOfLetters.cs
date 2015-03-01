//Problem 23. Series of letters
//Write a program that reads a string from the console and replaces all series
//of consecutive identical letters with a single one.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class SeriesOfLetters
    {
        static void Main()
        {
            Console.WriteLine("input string to replace repeated symbols");
            //string input = "aaaaabbbbbcdddeeeedssaa";
            string input = Console.ReadLine();
            
            string[] words = input.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length-1; j++)
                {
                    if (words[i][j]==words[i][j+1])
                    {
                        words[i] = words[i].Remove(j, 1);
                        j--;
                    }
                }
            }
            string result = string.Join(" ", words);
            Console.WriteLine(result);

        }
    }