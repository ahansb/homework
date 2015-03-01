//Problem 1. Leap year
//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

using System;


class LeapYear
{
    static void Main()
    {
        Console.WriteLine("input year to check is leap");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine(DateTime.IsLeapYear(year));
    }
}