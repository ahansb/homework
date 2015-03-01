//Problem 10. Unicode characters
//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UnicodeCharacters
    {
        static void Main()
        {
            //string input = "Hi!";
            Console.WriteLine("input text to see its Unicode chars");
            string input = Console.ReadLine();
            
            Console.WriteLine(ConvertToUnicode(input)); 
        }

        static string ConvertToUnicode(string input)
        {
            StringBuilder strB = new StringBuilder();
            foreach (var ch in input)
            {
                strB.AppendFormat("\\u{0:X4}", (int)ch);
            }
            string result = strB.ToString();
            return result;
        }
    }