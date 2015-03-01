//Problem 1. Fill the matrix
//Write a program that fills and prints a matrix of size (n, n) as shown below:

using System;
class FillTheMatrix
{
    static void Main()
    {
        //int n = 4;
        Console.WriteLine("input the leght of matri nxn:");
        int n = int.Parse(Console.ReadLine());

        int[,] matrixOne = new int[n, n];
        int counter = 1;

        //a)
        {
            for (int colA = 0; colA < n; colA++)
            {
                for (int rowA = 0; rowA < n; rowA++)
                {
                    matrixOne[colA, rowA] = counter;
                    counter++;
                }

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", matrixOne[j, i]);
                }
                Console.WriteLine();
            }
        }

        Console.WriteLine();
        //b)
        {
            int countB = 1;
            int rowCount = 3;
            for (int colB = 0; colB < n; colB++)
            {
                if (colB % 2 == 0)
                {
                    for (int rowB = 0; rowB < n; rowB++)
                    {
                        matrixOne[colB, rowB] = countB;
                        countB++;
                    }
                }
                else
                {
                    for (int rowB = n - 1; rowB >= 0; rowB--)
                    {
                        matrixOne[colB, rowB] = countB;
                        countB++;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", matrixOne[j, i]);
                }
                Console.WriteLine();
            }
        }
        Console.WriteLine();
        //c)
        {
            int number = 1;
            int row = 0;
            int col = 0;

            for (int i = n - 1; i >= 0; i--)//filling matrix under the diagonal
            {
                row = i;
                col = 0;
                while (row < n && col < n)
                {
                    matrixOne[row++, col++] = number++;
                }
            }

            for (int i = 1; i < n; i++)
            {
                row = 0;
                col = i;
                while (row < n && col < n)
                {
                    matrixOne[row++, col++] = number++;
                }
            }

            for (row = 0; row < n; row++)
            {
                for (col = 0; col < n; col++)
                {
                    Console.Write("{0,3} ", matrixOne[row, col]);
                }
                Console.WriteLine();
            }

        }
        Console.WriteLine("\n");
        //d)
        {
            int counterD = 1;
            int row = 0;
            int col = 0;
            int tempCount = 0;
            while (counterD <= n * n)
            {
                //down
                for (int i = row; i < n - tempCount; i++)
                {
                    matrixOne[i, col] = counterD;
                    counterD++;
                    row = i;
                }
                col++;
                //right
                for (int i = col; i < n - tempCount; i++)
                {
                    matrixOne[row, i] = counterD;
                    counterD++;
                    col = i;
                }
                row--;
                //up
                for (int i = row; i >= tempCount; i--)
                {
                    matrixOne[i, col] = counterD;
                    counterD++;
                    row = i;
                }
                col--;
                //left
                tempCount++;
                for (int i = col; i >= 0 + tempCount; i--)
                {
                    matrixOne[row, i] = counterD;
                    counterD++;
                    col = i;
                }
                row++;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", matrixOne[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}