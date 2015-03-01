//Problem 8. Extract sentences
//Write a program that extracts from a given text all sentences containing given word.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractSentences
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string[] sentences = SplitBySentence(text);
        string looking = "in";
        string result = SentecesWithWord(sentences, looking);
        Console.WriteLine(result);

    }

    private static string[] SplitBySentence(string text)
    {
        string[] sentence = text.Split('.');
        return sentence;
    }
        static string SentecesWithWord(string[] sentences, string looking)
    {

        StringBuilder strB = new StringBuilder();
        
        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].Contains(" "+looking+" "))
            {
                strB.Append(sentences[i]);
                strB.Append('.');
            }
            
        }

        string result = strB.ToString();
        
        return result;
    }
}