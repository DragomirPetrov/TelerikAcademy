using System;

namespace _06.FourDigits
{
    class FourDigits
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int a = (number % 10);
            int b = (number / 10) % 10;
            int c = (number / 100) % 10;
            int d = (number / 1000) % 10;
            int sum = (a + b + c + d);

            Console.WriteLine(sum);
            Console.WriteLine("{0}{1}{2}{3}", a, b, c, d);
            Console.WriteLine("{0}{1}{2}{3}", a, d, c, b);
            Console.WriteLine("{0}{1}{2}{3}", d, b, c, a);
        }
    }
}
