//Problem 13. Count words
//Write a program that reads a list of words from the file words.txt and finds how many times each 
//of the words is contained in another file test.txt.
//The result should be written in the file result.txt and the words should be sorted by the
//number of their occurrences in descending order.
//Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class CountWords
{
    static void Main()
    {
        try
        {
            var srWords = new StreamReader(@"..\..\words.txt");
            var srTest = new StreamReader(@"..\..\test.txt");
            var swResult = new StreamWriter(@"..\..\result.txt");
            var words = new List<string>();
            var test = new List<string>();
            var dict = new Dictionary<string, int>();
            using (srWords)
            {
                using (srTest)
                {
                    words = srWords.ReadToEnd().Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    test = srTest.ReadToEnd().Split(new char[] { ' ', '.', ',', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                }
            }
            int count = 0;
            for (int i = 0; i < words.Count; i++)
            {
                for (int j = 0; j < test.Count; j++)
                {
                    if (words[i] == test[j])
                    {
                        ++count;
                    }
                }
                dict.Add(words[i], count);
                count = 0;
            }
            var descending = dict.OrderByDescending(x => x.Value);
            using (swResult)
            {
                foreach (var item in descending)
                {
                    count++;
                    swResult.WriteLine("{2}. {0} - {1} times", item.Key, item.Value, count);
                }

            }

        }
        catch (Exception ex)
        {
            
             Console.WriteLine("{0}:{1}", ex.GetType().Name, ex.Message);;
        }
        
        Console.WriteLine("DONE");
    }
}