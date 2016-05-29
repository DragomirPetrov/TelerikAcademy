using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder reversed = new StringBuilder();

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed.Append(input[i]);
        }
        Console.WriteLine(reversed);
    }
}