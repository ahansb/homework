//Problem 17. Date in Bulgarian
//Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
//and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class DateInBulgarian
    {
        static void Main()
        {
            Console.WriteLine("input date and time given in the format: day.month.year hour:minute:second");
            //string date = "26.02.2015 11:28:32";
            string date = Console.ReadLine();
            
            DateTime cur = DateTime.Parse(date);
            DateTime  after = cur.AddHours(6).AddMinutes(30);
            System.Threading.Thread.CurrentThread.CurrentCulture =new CultureInfo("bg-BG");
            Console.WriteLine("after six hours and 30 secs the time is : {0:dd.MM.yyyy HH:mm:ss dddd}",after);
            
        }
    }