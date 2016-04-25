using System;

namespace something
{
    class something
    {
        static void Main()
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal c = decimal.Parse(Console.ReadLine());
            

            if (b == 2)
            {

                decimal rOne = (a % c);
                if (rOne % 4 == 0)
                {
                    Console.WriteLine(rOne / 4);
                    Console.WriteLine(a % c);
                }
                else
                {
                    Console.WriteLine(rOne % 4);
                    Console.WriteLine(a % c);
                }

            }
            else if (b == 4)
            {
                decimal rTwo = (a + c);
                if (rTwo % 4 == 0)
                {
                    Console.WriteLine(rTwo / 4);
                    Console.WriteLine(a + c);
                }
                else
                {
                    Console.WriteLine(rTwo % 4);
                    Console.WriteLine(a + c);
                }
            }
            else if (b == 8)
            {
                decimal rThree = (a * c);
                if (rThree % 4 == 0)
                {
                    Console.WriteLine(rThree / 4);
                    Console.WriteLine(a * c);
                }
                else
                {
                    Console.WriteLine(rThree % 4);
                    Console.WriteLine(a * c);
                }
            }
        }
    }
}
