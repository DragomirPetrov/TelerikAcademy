using System;
using System.Linq;

class GetLargestNumber
{
    static int GetMax(int first, int second)
    {
        if (first >= second)
        {
            return first;
        }
        else
        {
            return second;
        }
    }

    static void Main()
    {
        int[] numbers = Console.ReadLine()
        .Split(' ')
        .Select(int.Parse)
        .ToArray();

        int maxNumber = GetMax(numbers[0], numbers[1]);
        maxNumber = GetMax(maxNumber, numbers[2]);

        Console.WriteLine(maxNumber);
    }
}

