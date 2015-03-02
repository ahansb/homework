//Problem 10. Extract text from XML
//Write a program that extracts from given XML file all the text without the tags.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
class ExtractTextFromXML
{
    static void Main()
    {
        var sr = new StreamReader(@"..\..\TextFile1.txt");
        using (sr)
        {
            string line = sr.ReadLine();
            while(line!=null)
            {
                Console.WriteLine(ExtractHTML(line));
                line = sr.ReadLine();
            }
        }
    }
    static string ExtractHTML(string input)
    {

        bool isInBra = true;
        bool isOutsideBra = false;
        var sb = new StringBuilder();
        for (int i = 1; i < input.Length; i++)
        {
            if (isOutsideBra)
            {
                if (input[i] == '<')
                {
                    isInBra = true;
                    isOutsideBra = false;
                }
                else
                {
                    sb.Append(input[i]);
                }
            }
            if (isInBra)
            {
                if (input[i] == '>')
                {
                    isInBra = false;
                    isOutsideBra = true;
                }
                else
                {
                    continue;
                }
            }
        }
        string result = sb.ToString();
        return result;
    }
}
