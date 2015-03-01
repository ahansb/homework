//Problem 10. Find sum in array
//Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;
class FindSumInArray
{
    static void Main()
    {
        Console.WriteLine("Enter numbers separated by comma:");
        string input = Console.ReadLine();
        string[] inputStr = input.Split(',');
        int[] numbers = new int[inputStr.Length];

        for (int i = 0; i < inputStr.Length; i++)
        {
            numbers[i] = int.Parse(inputStr[i]);
        }
        Console.WriteLine("Enter desired SUM looking for:");
        int sum = int.Parse(Console.ReadLine());
        //int[] numbers = { 4, 3, 1, 4, 2, 5, 8 };
        //int sum = 11;
        int tempSum = 0;
        int counter = 0;


        for (int i = 0; i < numbers.Length; i++)
        {
            tempSum += numbers[i];
            counter++;
            if (tempSum < sum)
            {
                continue;
            }
            else if (tempSum == sum)
            {
                Console.Write("The number which sum is {0} are:", sum);
                for (int j = i - counter + 1; j <= i; j++)
                {
                    
                    Console.Write(numbers[j] + ", ");
                }
                Console.WriteLine();
            }
            else
            {
                tempSum = 0;
                i -= (counter - 1);
                counter = 0;
            }
        }

    }
}