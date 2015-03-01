//Problem 2. Maximal sum
//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;
class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Enter matrix of n,m");
        Console.WriteLine("Enter n>3");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter m>3");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.WriteLine("input matrix[{0},{1}]:", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }
        for (int row = 0; row < n; row++)
        {
            Console.WriteLine();
            for (int col = 0; col < m; col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
        }
        int sum = 0;
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < n - 2; row++)
        {
            for (int col = 0; col < m - 2; col++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                    + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                    + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;

                }

            }
        }
        Console.WriteLine("\nThe best sum element 3x3\n{0,3}{1,3}{2,3}\n{3,3}{4,3}{5,3}\n{6,3}{7,3}{8,3}", 
                        matrix[bestRow, bestCol] , matrix[bestRow, bestCol + 1] , matrix[bestRow, bestCol + 2],
                     matrix[bestRow + 1, bestCol] , matrix[bestRow + 1, bestCol + 1] , matrix[bestRow + 1, bestCol + 2]
                    , matrix[bestRow + 2, bestCol] , matrix[bestRow + 2, bestCol + 1] , matrix[bestRow + 2, bestCol + 2]);

    }
}