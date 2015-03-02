//Problem 8. Replace whole word
//Modify the solution of the previous problem to replace only whole words (not strings).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class ReplaceWholeWord
{
    static void Main()
    {
        var sr = new StreamReader(@"..\..\TextFile1.txt");

        var sw = new StreamWriter(@"..\..\replaced.txt");
        using (sr)
        {
            string line = sr.ReadLine();

            while (line != null)
            {
                for (int i = line.IndexOf("start"); i !=-1 ; i = line.IndexOf("start", i + 1))
                {
                    bool isWords = (i - 1 < 0||!char.IsLetter(line[i - 1])  ) && ( i + 5 >= line.Length||!char.IsLetter(line[i + 5]) );
                    if (isWords)
                    {
                        line = line.Replace("start", "finish");
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