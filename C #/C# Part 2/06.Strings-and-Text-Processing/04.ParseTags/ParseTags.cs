using System;
using System.Text;
using System.Linq;

class ParseTags
{
    static void Main()
    {
        string openTag = "upcase";
        string closeTag = "/upcase";

        var toParse = Console
            .ReadLine()
            .Split(new char[] { '<', '>' })
            .ToArray();

        StringBuilder output = new StringBuilder();
        bool toUpper = false;

        foreach (var word in toParse)
        {
            if (word == openTag)
            {
                toUpper = true;
                continue;
            }

            if (word == closeTag)
            {
                toUpper = false;
                continue;
            }

            if (toUpper)
            {
                output.Append(word.ToUpper());
            }
            else
            {
                output.Append(word);
            }
        }
        Console.WriteLine(output);
    }
}

