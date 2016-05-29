using System;

class AllocateArray
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = 5 * i;
            Console.WriteLine("{0}", array[i]);
        }
    }
}

