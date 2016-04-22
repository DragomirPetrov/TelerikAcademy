using System;

namespace _01.SumOfThreeNumbers
{
    class SumOfThreeNumbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double result = (a + b + c);
            Console.WriteLine(result);
        }
    }
}
