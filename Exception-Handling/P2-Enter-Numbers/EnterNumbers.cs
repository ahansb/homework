//Problem 2. Enter numbers
//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;


class EnterNumbers
{
    static void Main()
    {

        try
        {
            Console.WriteLine("Input low border of range");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Input upper border of range");
            int end = int.Parse(Console.ReadLine());
            ReadNumber(start, end);
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("The input could not be null.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number must fit int32.");
        }
    }
    static void ReadNumber(int start, int end)
    {
        Console.WriteLine("input 10 numbers in the range [{0}:{1}]",start,end);
        for (int i = 0; i < 10; i++)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                if (num < start || end < num)
                {
                    throw new System.ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException)
            {

                Console.WriteLine("The number is out of the given range!");
            }
            
        }

    }
}