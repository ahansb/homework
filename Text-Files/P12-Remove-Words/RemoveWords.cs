//Problem 12. Remove words
//    Write a program that removes from a text file all words listed in given another text file.
//    Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class RemoveWords
{
    static void Main()
    {

        var sr = new StreamReader(@"..\..\TextFile1.txt");
        var srList = new StreamReader(@"..\..\TextFile2.txt");
        var sw = new StreamWriter(@"..\..\replaced.txt");
       string[] list;
        using (srList)
        {
            string line = srList.ReadLine();
            while(line!=null)
            {
                list = line.Split(' ');
                line = srList.ReadLine();
            }
        }

        
            RemoveWordsFromTxtFiles(sr, sw, list);
       
            
            
        
        




    }

    private static void RemoveWordsFromTxtFiles(StreamReader sr, StreamWriter sw, string[]list)
    {

        using (sr)
        {
            string line = sr.ReadLine();

            while (line != null)
            {
                foreach (var word in list)
                {
                    for (int i = line.IndexOf(word); i != -1; i = line.IndexOf(word, i + 1))
                    {
                        bool isWords = (i - 1 < 0 || !char.IsLetter(line[i - 1])) && (i + 5 >= line.Length || !char.IsLetter(line[i + 5]));
                        if (isWords)
                        {
                            line = line.Replace(word, " ");
                        }
                    }
                }
                



                sw.WriteLine(line);
                line = sr.ReadLine();

            }
        }

        sw.Close();
        Console.WriteLine("Done");
    }
}