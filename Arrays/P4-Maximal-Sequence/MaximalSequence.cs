//Problem 4. Maximal sequence
//Write a program that finds the maximal sequence of equal elements in an array.

using System;
class MaximalSequence
{
    static void Main()
    {
        Console.WriteLine("Enter the lenght of the array you want to enter:");
        int lenght = int.Parse(Console.ReadLine());
        int[] numbers = new int[lenght];
        int curCount = 1;
        int curNum = 0;
        int finCount = 0;
        int finNum = 0;

        Console.WriteLine("Enter 1 number: ");
        numbers[0] = int.Parse(Console.ReadLine());

        for (int i = 1; i < lenght; i++)
        {
            Console.WriteLine("Enter {0} number: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());

            if (numbers[i] == numbers[i - 1])
            {
                ++curCount;
                curNum = numbers[i];
            }
            if (curCount > finCount)
            {
                finCount = curCount;
                finNum = curNum;
            }

        }
        if (finCount == 1)
        {
            Console.WriteLine("there is no match b/n elements");
        }
        else
        {
            Console.WriteLine("{0} is the most long sequence, showed {1} times", finNum, finCount);
            for (int i = 0; i < finCount; i++)
            {
                Console.Write("{0}, ", finNum);
            }
        }

    }
}