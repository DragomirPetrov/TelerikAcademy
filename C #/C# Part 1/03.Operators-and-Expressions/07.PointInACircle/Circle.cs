using System;

namespace _07.PointInACircle
{
    class Circle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double r = 2;

            double distance = (x * x) + (y * y);
            bool result = distance <= (r * r);
            if (result)
            {
                Console.WriteLine("yes {0:F2}", Math.Sqrt(distance));
            }
            else
            {
                Console.WriteLine("no {0:F2}", Math.Sqrt(distance));
            }
        }
    }
}
