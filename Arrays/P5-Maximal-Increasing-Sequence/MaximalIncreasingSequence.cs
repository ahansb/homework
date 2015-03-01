//Problem 5. Maximal increasing sequence
//Write a program that finds the maximal increasing sequence in an array.


using System;
class MaximalIncreasingSequence
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

        for (int i = 1; i < lenght;  i++)
        {
            Console.WriteLine("Enter {0} number: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());

            if (numbers[i] == numbers[i - 1]+1)
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
        //Console.WriteLine("{0} is the most long sequence, showed {1} times", finNum, finCount);
        Console.WriteLine("The longest sequence is: ");
        for ( int i = finCount; i >0; i--)
        {
            Console.Write("{0}, ", finNum+1 - i);
        }
    }
}