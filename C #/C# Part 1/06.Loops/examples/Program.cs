﻿using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;

        if (number <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }
            if (isPrime == false)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
