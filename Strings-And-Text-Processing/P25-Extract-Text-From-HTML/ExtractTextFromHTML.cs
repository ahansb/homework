//Problem 25. Extract text from HTML
//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractTextFromHTML
{
    static void Main()
    {
        string input = @"<html><head><title>News </title></head><body><p><a href=""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>";
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
                if(input[i]=='>')
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
        Console.WriteLine(result);
    }
}