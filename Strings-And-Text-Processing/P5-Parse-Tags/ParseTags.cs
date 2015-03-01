//Problem 5. Parse tags
//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> 
//and </upcase> to upper-case.
//The tags cannot be nested.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ParseTags
{
    static void Main()
    {
        //string input = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Console.WriteLine("input text and the words in <upcase> ... </upcase>\" will be AllCaps");
        string input = Console.ReadLine();
        
        string result = UpCase(input);
        Console.WriteLine(result);
        
    }

    static string UpCase(string input)
    {

        StringBuilder strB = new StringBuilder();
        string looking = "<upcase>";
        string lookEnd = "</upcase>";
        int counter = 1;
        for (int i = 0; i < input.Length; i++)
        {
            int idxToStart = input.IndexOf(looking, i);
            int start = input.IndexOf(looking, i) + looking.Length;
            int end = input.IndexOf(lookEnd, i);
            if (idxToStart < 0 || end < 0)
            {
                strB.Append(input.Substring(i, (input.Length  - i)));
                break;

            }
            else
            {
                strB.Append(input.Substring(i, idxToStart - i));
                strB.Append(input.Substring(start, end - start).ToUpper());
                i = strB.Length + ((looking.Length + lookEnd.Length ) * counter - 1);
                counter++;
            }
        }

        string result = strB.ToString();
        return result;
    }
}