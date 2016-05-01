using System;

namespace _11.Interval
{
    class Interval
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int interval = 0;

            for (int i = n + 1; i < m; i++)
            {
                if (i % 5 == 0)
                {
                    interval++;
                }
            }
            
            Console.WriteLine(interval);
        }
    }
}
