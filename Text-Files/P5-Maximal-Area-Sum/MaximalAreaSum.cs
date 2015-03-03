//Problem 5. Maximal area sum
//    Write a program that reads a text file containing a square matrix of numbers.
//    Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//        The first line in the input file contains the size of matrix N.
//        Each of the next N lines contain N numbers separated by space.
//        The output should be a single number in a separate text file.


using System;
using System.IO;

class MaximalAreaSum
{
    static void Main()
    {
        var sr = new StreamReader(@"..\..\TextFile1.txt");
        using (sr)
        {
            string sizeOfMatrix = sr.ReadLine();
            int n = int.Parse(sizeOfMatrix);
            int m = int.Parse(sizeOfMatrix);
            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                string[] line = sr.ReadLine().Split(' ');
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = int.Parse(line[col]);
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
            for (int row = 0; row < n - 1; row++)
            {
                for (int col = 0; col < m - 1; col++)
                {
                    sum = matrix[row, col] + matrix[row, col + 1]
                    + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            Console.WriteLine("\n\nThe best sum is {0}",bestSum);
            Console.WriteLine("\nThe best sum element 2x2\n{0,3}{1,3}\n{2,3}{3,3}",
            matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1],
            matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1]);
        }
    }
}
