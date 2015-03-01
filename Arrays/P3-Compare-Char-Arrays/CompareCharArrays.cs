//Problem 3. Compare char arrays
//Write a program that compares two char arrays lexicographically (letter by letter).

using System;
class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("Write something to compare:");
        string firstCharsStr = Console.ReadLine();
        Console.WriteLine("Write something to compare to:");
        string secCharsStr = Console.ReadLine();

        char[] firstChsrs = firstCharsStr.ToCharArray();
        char[] secChars = secCharsStr.ToCharArray();

        int lenght;
        if (firstCharsStr.Length>secCharsStr.Length)
        {
            lenght = secCharsStr.Length;
            Console.WriteLine("Different lenght!");
        }
        else if (firstCharsStr.Length<secCharsStr.Length)
        {
            lenght = firstCharsStr.Length;
            Console.WriteLine("Different lenght!");

        }
        else
        {
            lenght = firstCharsStr.Length;
        }

        for (int i = 0; i < lenght; i++)
        {
            
            Console.Write("The chars are: {0} - {1}", firstChsrs[i], secChars[i]);
            if (firstChsrs[i] == secChars[i])
            {
                Console.Write(" we have the same letter");
            }
            Console.WriteLine();
        }



    }
}