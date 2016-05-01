using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoding___niki
{
    class Program
    {
        static void Main()
        {
            int salt = int.Parse(Console.ReadLine());
            int position = 0;
            
            while (true)
            {
                int charCode = Console.Read();
                char ch = (char)charCode;

                if (ch == '@')
                {
                    break;
                }

                int newCode = 0;
                if (char.IsLetter(ch))
                {
                    newCode = charCode * salt + 1000;
                }
                else if (char.IsDigit(ch)) //(ch >= '0' && ch <= '9')
                {
                    newCode = charCode + salt + 500;
                }
                else
                {
                    newCode = charCode - salt;
                }

                if (position % 2 == 0)
                {
                    Console.WriteLine("{0:0.00}", newCode / 100.00);
                }
                else
                {
                    Console.WriteLine(newCode * 100);
                }
                position++;

            }






        }
    }
}
