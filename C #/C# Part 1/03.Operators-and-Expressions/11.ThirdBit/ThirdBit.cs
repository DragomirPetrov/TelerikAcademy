﻿using System;

namespace _11.ThirdBit
{
    class ThirdBit
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int position = 3;
            int mask = 1 << position;
            int result = number & mask;
            int bit = result >> position;

            Console.WriteLine(bit);
        }
    }
}
