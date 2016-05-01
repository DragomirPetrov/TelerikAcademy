using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long k = long.Parse(Console.ReadLine());
        BigInteger factorial = 1;

        for (long i = k + 1; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}