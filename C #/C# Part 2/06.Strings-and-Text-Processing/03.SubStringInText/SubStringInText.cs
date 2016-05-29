using System;

class SubStringInText
{
    static void Main()
    {
        string pattern = Console.ReadLine().ToLower();
        string text = Console.ReadLine().ToLower();

        int found = text.IndexOf(pattern);
        int counter = 0;

        while (found >= 0)
        {
            counter++;

            found = text.IndexOf(pattern, ++found);
        }
        Console.WriteLine(counter);
    }
}