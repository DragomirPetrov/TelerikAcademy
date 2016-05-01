using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int limit = n;

        for (int row = 1; row <= n; row++)
        {
            for (int col = row; col <= limit; col++)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
            limit++;
        }
    }
}