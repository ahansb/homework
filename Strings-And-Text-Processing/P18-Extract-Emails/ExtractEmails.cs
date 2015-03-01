//Problem 18. Extract e-mails
//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
class ExtractEmails
{
    static void Main()
    {
        string data = "asd@asd.bg,asdf.AS@asd.bg,asdf.A@asd.bg,asdfsadgfdsf,asdf.S@abv.bg";
        Regex emailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            RegexOptions.IgnoreCase);
        //find items that matches with our pattern
        MatchCollection emailMatches = emailRegex.Matches(data);

        StringBuilder sb = new StringBuilder();

        foreach (Match emailMatch in emailMatches)
        {
            sb.AppendLine(emailMatch.Value);
        }
        //print
        Console.WriteLine(sb.ToString());
    }
}