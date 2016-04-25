using System;

class Program
{
    static void Main()
    {

        long number = long.Parse(Console.ReadLine());
        string binary = string.Empty;

        while (number > 0)
        {
            binary += number % 2;
            number = number / 2;
        }

        for (int i = binary.Length - 1; i >= 0; i--)
        {
            Console.Write(binary[i]);
        }
    }
}

