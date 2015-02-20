//Problem 11. Adding polynomials
//Write a method that adds two polynomials.
//Represent them as arrays of their coefficients.

using System;

class AddingPolynomials
{
    static void Main()
    {
        int[] polynomOne = { 1, 2, 3, 5, 3 };
        int[] polynomTwo = { 4, 5, 6, 7 };

        PrintPolynom(polynomOne);
        Console.WriteLine();
        PrintPolynom(polynomTwo);
        Console.WriteLine();
        PrintPolynom(SumPolynom(polynomOne, polynomTwo));
        Console.WriteLine();

    }

    static int[] SumPolynom(int[] polynomOne, int[] polynomTwo)
    {

        if (polynomTwo.Length > polynomOne.Length)
        {
            int[] polynomSum = new int[polynomTwo.Length];
            for (int i = polynomOne.Length - 1; i >= 0; i--)
            {
                polynomSum[i] = polynomOne[i] + polynomTwo[i];
            }
            for (int i = polynomTwo.Length - 1; i > polynomOne.Length - 1; i--)
            {
                polynomSum[i] = polynomTwo[i];
            }
            return polynomSum;
        }
        else if (polynomTwo.Length < polynomOne.Length)
        {
            int[] polynomSum = new int[polynomOne.Length];
            for (int i = polynomTwo.Length - 1; i >= 0; i--)
            {
                polynomSum[i] = polynomOne[i] + polynomTwo[i];
            }
            for (int i = polynomOne.Length - 1; i > polynomTwo.Length - 1; i--)
            {
                polynomSum[i] = polynomOne[i];
            }
            return polynomSum;
        }
        else
        {
            int[] polynomSum = new int[polynomOne.Length];
            for (int i = polynomOne.Length - 1; i >= 0; i--)
            {
                polynomSum[i] = polynomOne[i] + polynomTwo[i];
            }

            return polynomSum;
        }

    }

    private static void PrintPolynom(int[] polynom)
    {
        string separator = string.Empty;
        for (int i = polynom.Length - 1; i >= 0; i--)
        {

            Console.Write(separator);
            Console.Write("{0}x^{1}", polynom[i], i);
            separator = "+";
        }
        Console.WriteLine();
    }
}

