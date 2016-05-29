using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class ParseURL
{
    static void Main()
    {
        var format = new string[]
            {
                "[protocol] = {0}",
                "[server] = {0}",
                "[resource] = /{0}"
            };

        var toParse = Console.ReadLine();

        var URLPattern = (@"(\w*)://(.*)/(.*)");

        var Match = Regex.Match(toParse, URLPattern, RegexOptions.RightToLeft);

        var toPrint = new List<object>();

        foreach (var group in Match.Groups)
        {
            if (group.ToString() != toParse)
            {
                toPrint.Add(group);
            }
        }
        for (int index = 0; index < 3; index++)
        {
            Console.WriteLine(string.Format(format[index], toPrint[index]));
        }
    }
}