using System;

namespace _07.SortThreeNumbers
{
    class SortThreeNumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c && b > c)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            else if (a > b && a > c && c > b)
            {
                Console.WriteLine("{0} {1} {2}", a, c, b);
            }
            else if (b > a && b > c && c < a)
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);
            }
            else if ((b > a && b > c && c > a))
            {
                Console.WriteLine("{0} {1} {2}", b, c, a);
            }
            else if (c > a && c > b && a > b)
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
        }
    }
}
