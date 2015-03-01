//Problem 9. Forbidden words
//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ForbiddenWords
{
    static void Main()
    {
        //string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        Console.WriteLine("input text with forbidden words");
        string text = Console.ReadLine();
        Console.WriteLine("input forbidden words separated by space");
        string fWorsds = Console.ReadLine();
        string[] sep = fWorsds.Split(' ');
        List<string> forbidden = sep.ToList();
        //List<string> forbidden = new List<string> { "PHP", "CLR", "Microsoft" };

        char asterix = '*';
        string newTxt = ReplaceForbiddenWords(text, forbidden,asterix);
        Console.WriteLine(newTxt);

    }

    static string ReplaceForbiddenWords(string text, List<string> forbidden, char ch)
    {
        
        string[] txt = text.Split(new char[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var word in forbidden)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                text = text.Replace(word, new string(ch, word.Length));
            }
        }
        string result = text;
        return result;
    }
}