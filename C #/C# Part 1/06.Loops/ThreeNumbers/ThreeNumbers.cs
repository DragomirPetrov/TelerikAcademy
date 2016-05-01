using System;

namespace ThreeNumbers
{
    class ThreeNumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            decimal avg = (a + b + c) / 3.0M;

            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            int min = a;
            if (b < min)
            {
                min = b;
            }
            if (c < min)
            {
                min = c;
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine("{0:F2}", avg);
        }
    }
}