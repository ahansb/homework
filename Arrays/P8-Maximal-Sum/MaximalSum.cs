//Problem 8. Maximal sum
//Write a program that finds the sequence of maximal sum in given array.

using System;
class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Finding the biggest sequence sum. Enter the numbers in a line separated by ','");
        string input = Console.ReadLine(); 
        //string input = "-1,2,3,-7,3,4,-5";
        string[] numbersStr = input.Split(',');
        int[] numbers = new int[numbersStr.Length];
        for (int i = 0; i < numbersStr.Length; i++)
        {
            numbers[i] = int.Parse(numbersStr[i]);
        }
        long bestSum = int.MinValue;
        long curSum = 0;
        
        int end = 0;
        int startInd = 0;
        int start = 0;
        
            for (int i = 0; i < numbers.Length; i++)
            {
                curSum += numbers[i];
                 if (curSum <= 0)
                {

                    curSum = 0;
                    startInd = i+1;
                }
                if (curSum > bestSum)
                {
                    start = startInd;
                    bestSum = curSum;
                    end = i;
                    
                }
                
            }
            Console.WriteLine();
            for (int i =start; i <= end; i++)
            {
                Console.Write("{0}, ", numbers[i]);
            }
        
    }
}