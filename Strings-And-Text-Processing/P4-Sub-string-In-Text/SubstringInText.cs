//Problem 4. Sub-string in text
//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SubstringInText
    {
        static void Main()
        {
            //string input = @"INThe text is as follows: We are living in an yellow submarine. 
           // We don't have anything else. inside the submarine is very tight. So we are drinking all the day. 
            //We will move out of it in 5 days.";
            //string looking = "in";

            Console.WriteLine("input text:");
            string input = Console.ReadLine();
            Console.WriteLine("input word looking for:");
            string looking = Console.ReadLine();
            
            int count = HowManyTimesContains(input, looking);
            Console.WriteLine("{0} is met {1} times in text.", looking,count);
        }

        static int HowManyTimesContains(string input, string looking)
        {
            int count = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input.Substring(i, looking.Length).ToLower() == looking)
                {
                    count++;
                    i += looking.Length;

                }
            }
            return count;
        }
    }