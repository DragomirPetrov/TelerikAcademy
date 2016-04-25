using System;
using System.Numerics;


class CatalanNumbers
{
    private static BigInteger FindPartialFactorial(uint startNumber, uint N)
    {
        BigInteger factorial = (BigInteger)startNumber;
        for (uint i = startNumber + 1; i < N + 1; i++)
        {
            factorial = factorial * i;
        }
        return factorial;
    }
    static void Main()
    {
        BigInteger Nth_element;
        uint N;
        Console.Write("");
        bool isNUint = uint.TryParse(Console.ReadLine(), out N);
        if (isNUint)
        {
            Nth_element = FindPartialFactorial((N + 1), (2 * N)) / FindPartialFactorial(1, N + 1);
            Console.WriteLine("{0}", Nth_element);
        }
    }
}