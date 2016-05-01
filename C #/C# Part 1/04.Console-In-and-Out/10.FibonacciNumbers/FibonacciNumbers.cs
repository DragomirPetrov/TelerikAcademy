using System;

namespace _10.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());

            long a = -1;
            long b = 1;
            long sum = 0;

            for (int i = 0; i < numbers; i++)
            {
                sum = a + b;
                if (i != numbers - 1)
                {
                    Console.Write(sum + ", ");
                }
                else
                {
                    Console.WriteLine(sum);
                }
                a = b;
                b = sum;
            }
        }
    }
}
