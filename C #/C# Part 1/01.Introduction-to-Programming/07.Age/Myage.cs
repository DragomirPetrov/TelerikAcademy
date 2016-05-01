using System;

namespace _07.Age
{
    class MyAge
    {
        static void Main()
        {
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            int currentAge = (int)((DateTime.Now - birthDate).TotalDays / 365.242199);

            Console.WriteLine(currentAge);
            Console.WriteLine(currentAge + 10);
        }
    }
}
