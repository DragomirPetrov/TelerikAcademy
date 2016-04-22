using System;

namespace _09.Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = height * ((sideA + sideB) / 2);

            Console.WriteLine("{0:F7}", area);
        }
    }
}
