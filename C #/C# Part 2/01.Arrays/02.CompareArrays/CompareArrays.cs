using System;
using System.Linq;

class CompareArrays
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] firstRow = new int[n];
        int[] secondRow = new int[n];

        for (int i = 0; i < firstRow.Length; i++)
        {
            firstRow[i] = int.Parse(Console.ReadLine());
        }
        for (int j = 0; j < secondRow.Length; j++)
        {
            secondRow[j] = int.Parse(Console.ReadLine());
        }
        if (firstRow.SequenceEqual(secondRow))
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}

