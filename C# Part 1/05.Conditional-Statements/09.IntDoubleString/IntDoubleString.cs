using System;

namespace _09.IntDoubleString
{
    class IntDoubleString
    {
        static void Main()
        {
            string ids = Console.ReadLine();

            switch (ids)
            {
                case "integer":
                int first = int.Parse(Console.ReadLine());
                Console.WriteLine(first + 1); break;
                case "real":
                double second = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", second + 1); break;
                case "text":
                string third = Console.ReadLine();
                Console.WriteLine(third + "*"); break;
                default: Console.WriteLine("Invalid"); break;
            }
        }
    }
}
