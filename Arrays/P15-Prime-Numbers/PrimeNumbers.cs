//Problem 15. Prime numbers
//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;
using System.Collections;
using System.Collections.Generic;

class PrimeNumbers
{
    static void Main(string[] args)
    {
        int maxprime = 10000000;
        var primelist = GetAllPrimesLessThan(maxprime);
        foreach (int prime in primelist)
        {
            Console.WriteLine(prime);
        }
        Console.WriteLine("Count = " + primelist.Count);
        Console.ReadLine();
    }

    static List<int> GetAllPrimesLessThan(int maxPrime)
    {
        var primes = new List<int>() { 2 };
        var maxSquareRoot = Math.Sqrt(maxPrime);
        var eliminated = new BitArray(maxPrime + 1);

        for (int i = 3; i <= maxPrime; i += 2)
        {
            if (!eliminated[i])
            {
                primes.Add(i);
                if (i < maxSquareRoot)
                {
                    for (int j = i * i; j <= maxPrime; j += 2 * i)
                    {
                        eliminated[j] = true;
                    }
                }
            }
        }
        return primes;
    }
}
