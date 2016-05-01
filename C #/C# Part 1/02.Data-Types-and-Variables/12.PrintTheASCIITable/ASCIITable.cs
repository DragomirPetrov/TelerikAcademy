using System;
using System.Text;

namespace _12.PrintTheASCIITable
{
    class ASCIITable
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 33; i <= 126; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
