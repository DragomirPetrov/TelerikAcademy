using System;

namespace _01.ExchangeNumbers
{
    class ExchangeNumbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
                Console.WriteLine("{0} {1}", a, b);
            }
            else 
            {
               Console.WriteLine("{0} {1}", a, b);
            }
        }
    }
}
