//Problem 14. Word dictionary
//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WordDictionary
{
    static void Main()
    {
        Dictionary<string, string> d = new Dictionary<string, string>(){
	    {".NET", "platform for applications from Microsoft"},
	    {"CLR", "managed execution environment for .NET"},
	    {"namespace", "hierarchical organization of classes"}};
        Console.WriteLine("Enter one of : .NET; CLR; namespace.");
        string input = Console.ReadLine();
        if (d.ContainsKey(input))
	{
	    string value = d[input];
	    Console.WriteLine(value);
	}
        if (!d.ContainsKey(input))
        {
            Console.WriteLine(false);
        }
        
    }
}