using System;

class CompareCharArrays
{
    static void Main(string[] args)
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        int charLenght = Math.Min(first.Length, second.Length);

        for (int i = 0; i < charLenght; i++)
        {
            if (first[i] > second[i] || i == charLenght - 1 && first.Length > second.Length)
            {
                Console.WriteLine(">");
                break;
            }
            else if (first[i] < second[i] || i == charLenght - 1 && first.Length < second.Length)
            {
                Console.WriteLine("<");
                break;
            }
            else if (i == charLenght - 1 && first.Length == second.Length)
            {
                Console.WriteLine("=");
            }
        }
    }
}

