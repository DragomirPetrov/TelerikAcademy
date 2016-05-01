using System;

namespace _02.MoonGravity
{
    class MoonGravity
    {
        static void Main()
        {
            float weight = float.Parse(Console.ReadLine());
            float weightOnMoon = weight * 0.17f;
            Console.WriteLine("{0:F3}", weightOnMoon);
        }
    }
}
