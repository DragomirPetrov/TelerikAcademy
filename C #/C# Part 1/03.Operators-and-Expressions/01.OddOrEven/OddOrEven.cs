﻿using System;

namespace _01.OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
           
                if (number % 2 == 0)
                {
                    Console.WriteLine("even " + number);
                }
                else
                {
                    Console.WriteLine("odd " + number);
                }
        }
    }
}
