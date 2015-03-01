//Problem 19. Dates from text in Canada
//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

 class DatesFromTextInCanada
    {
        static void Main()
        {
            string text =@"Hello, I'm a String... This is a Stackoverflowquestion!! 
Here is a Date: 16.03.2013, 02:35 and yeah, plain text blah blah..-. This the other string!
:) 22.11.2012. Its a Date you see";
            var regex = new Regex(@"\b\d{2}\.\d{2}.\d{4}\b");
            foreach (Match m in regex.Matches(text))
            {
                DateTime dt;
                if (DateTime.TryParseExact(m.Value, "dd.MM.yyyy", null, DateTimeStyles.None, out dt)) ;
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
                Console.WriteLine(dt);
                
            }
        }
    }