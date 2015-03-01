//Problem 22. Words count
//Write a program that reads a string from the console and lists all different words in the 
//string along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WordsCount
{
    static void Main()
    {
        //string textIn = @"repeaT Text,repeaT Text repeaT Text.repeaT Text,repeaT Text, rEpeated";
        Console.WriteLine("input text to count the words:");
        string textIn = Console.ReadLine();
        
        string text = textIn.ToLower();
        string[] words = text.Split(new char []{' ', ',', '.'},StringSplitOptions.RemoveEmptyEntries).ToArray();
        Dictionary<string, int> d = new Dictionary<string, int>();
        foreach (var word in words)
        {
            if (d.ContainsKey(word))
            {
                d[word]++;
            }
            else
            {
                d.Add(word, 1);
            }
        }
        foreach (var word in d)
        {
            Console.WriteLine("{0} - {1} times",word.Key,word.Value);
        }

    }
}