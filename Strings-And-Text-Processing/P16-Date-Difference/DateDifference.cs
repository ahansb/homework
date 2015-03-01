//Problem 16. Date difference
//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DateDifference
    {
        static void Main()
        {
            Console.WriteLine("input two dates in format dd.MM.yyyy by pressing [Enter]");
            string firstDate = Console.ReadLine();
            //string firstDate = "27.02.2006";
            string secDate = Console.ReadLine();
            //string secDate = "3.03.2006";
            DateTime one = DateTime.Parse(firstDate);
            DateTime two = DateTime.Parse(secDate);
            var result = Math.Abs((two.Date - one.Date).TotalDays);
            Console.WriteLine(result);
        }
    }