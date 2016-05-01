using System;

namespace _04.FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            string binary = Convert.ToString(a, 2).PadLeft(10, '0');
            Console.WriteLine("{0:X} |{1}| {2:F2}|{3:F3} |", a, binary, b, c);
        }
    }
}
