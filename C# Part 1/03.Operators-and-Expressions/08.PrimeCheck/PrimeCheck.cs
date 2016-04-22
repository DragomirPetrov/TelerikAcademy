using System;

namespace _08.PrimeCheck
{
    class PrimeCheck
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            bool prime = true;

            if (n < 2)
            {
                prime = false;
            }
            else
            {
                for (int i = 2; i <= (int)Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        prime = false;
                    }
                }
            }

            if (prime)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}