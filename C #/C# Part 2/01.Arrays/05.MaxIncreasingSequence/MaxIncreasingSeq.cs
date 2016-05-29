using System;

class MaxIncreasingSeq
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] sequence = new int[n];

        for (int i = 0; i < n; i++)
        {
            sequence[i] = int.Parse(Console.ReadLine());
        }

        int currentSeq = 1;
        int maxSeq = 1;

        for (int i = 1; i < sequence.Length; i++)
        {
            if (sequence[i] > sequence[i - 1])
            {
                currentSeq++;
            }
            else
            {
                if (currentSeq > maxSeq)
                {
                    maxSeq = currentSeq;
                }
                currentSeq = 1;
            }
        }
        Console.WriteLine(maxSeq);
    }
}

