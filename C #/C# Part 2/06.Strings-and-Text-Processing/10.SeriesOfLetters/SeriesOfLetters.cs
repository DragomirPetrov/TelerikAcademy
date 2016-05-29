using System;
using System.Collections.Generic;

class SeriesOfLetters
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<char> singleLetters = new List<char>();
        singleLetters.Add(input[0]);
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i - 1] == input[i])
            {
                continue;
            }
            else
            {
                singleLetters.Add(input[i]);
            }
        }
        Console.WriteLine(string.Join("", singleLetters));
    }
}