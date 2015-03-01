//Problem 5. Workdays
//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of 
//public holidays specified preliminary as array.


using System;
using System.Linq;
class Workdays
{
    static void Main()
    {
        

        Console.WriteLine("Input a future date to calc how many workdays are?");
        Console.WriteLine("Input date - day");
        int day = int.Parse(Console.ReadLine());
        Console.WriteLine("input date - month");
        int month = int.Parse(Console.ReadLine());
        DateTime now = DateTime.Today;
        DateTime future = new DateTime(2015, month, day);
        if (future<now)
        {
            Console.WriteLine("You must ENTER FUTURE DATE");
            return;
        }

        int workDays = WorkingDays(future);
        Console.WriteLine(workDays);
    }

    static int WorkingDays(DateTime future)
    {
        DateTime now = DateTime.Today;
        DateTime[] holidays = {new DateTime(2015,01,01),new DateTime(2015,03,02),
                                  new DateTime(2015,03,03),new DateTime(2015,04,10),
                                  new DateTime(2015,4,11),new DateTime(2015,4,12),
                                  new DateTime(2015,4,13),new DateTime(2015,05,01),
                                  new DateTime(2015,05,06),new DateTime(2015,9,21),
                                  new DateTime(2015,09,22),new DateTime(2015,12,24),
                                  new DateTime(2015,12,24),new DateTime(2015,12,26),new DateTime(2015,12,31),};
        

        int workDays = 0;
        while (now.Date < future.Date)
        {
            now = now.AddDays(1);
            if (now.DayOfWeek != DayOfWeek.Saturday && now.DayOfWeek != DayOfWeek.Sunday && !holidays.Contains(now))
            {
                ++workDays;
            }
            
        }
        return workDays;
    }
}