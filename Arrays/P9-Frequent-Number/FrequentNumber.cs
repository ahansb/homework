//Problem 9. Frequent number
//Write a program that finds the most frequent number in an array.

using System;
class FrequentNumber
{
    static void Main()
    {
        Console.WriteLine("Write an int arry sepparated by comma:");

        string[] numberstring = Console.ReadLine().Split(',');
        int[] numbers = new int[numberstring.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(numberstring[i]);
        }
        Array.Sort(numbers);
        int counter = 1;
        int index = 0;
        int bestCount = 0;
        int bestInd = 0;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                ++counter;
                index = i;
                if (counter > bestCount)
                {
                    bestCount = counter;
                    bestInd = index;
                }

            }
            else
            {
                counter = 1;
            }

        }
        if (bestCount == 0)
        {
            Console.WriteLine("all numbers are showed only once");
        }
        else
        {
            Console.WriteLine("{0} ({1}times)", numbers[bestInd], bestCount);
            Console.WriteLine();
        }


    }
}