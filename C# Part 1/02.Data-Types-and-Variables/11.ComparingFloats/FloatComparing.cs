using System;

namespace _11.ComparingFloats
{
    class FloatComparing
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            bool equal = Math.Abs(a - b) < 0.000001;

            if (equal)
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
