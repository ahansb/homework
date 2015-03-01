//Problem 7. Selection sort
//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest
//from the rest, move it at the second position, etc.


using System;

class SelectionSort
{
    static void Main()
    {
        Console.WriteLine("Enter how many nums you want to be in the array");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        //int[] numbers = { 5, 2, 3, 1, 6, 9, 7, 8, 4 };
        int curNum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("enter number {0}:", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[i] > numbers[j])
                    {

                        curNum = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = curNum;

                    }
                }



            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}, ", numbers[i]);
            }
        }
    }
}