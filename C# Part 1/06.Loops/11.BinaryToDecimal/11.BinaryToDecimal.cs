using System;

namespace _11.BinaryToDecimal
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            long result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int num = input[i] - 48;

                if (num == 1)
                {
                    result += (Power(2, input.Length - i - 1));
                }
            }

            Console.WriteLine(result);
        }

        public static long Power(int number, int power)
        {
            long result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }

    }
}
