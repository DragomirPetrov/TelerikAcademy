using System;

namespace _05.ThirdDigit
{
    class ThirdDigit
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            n = (n / 100) % 10;

            bool thirdDigit = (n == 7);
            if (thirdDigit)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false " + n);
            }
        }
    }
}
