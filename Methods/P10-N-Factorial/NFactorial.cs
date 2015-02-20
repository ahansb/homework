//Problem 10. N Factorial
//Write a program to calculate n! for each n in the range [1..100].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        int start = 1;
        int end = 100;
        for (int n = start; n <= end; n++)
        {
            Console.WriteLine(NFactorialCalc(n));
        }
    }

    static BigInteger NFactorialCalc(int n)
    {
        BigInteger nFactorial = 1;

        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
        }

        return nFactorial;
    }
}