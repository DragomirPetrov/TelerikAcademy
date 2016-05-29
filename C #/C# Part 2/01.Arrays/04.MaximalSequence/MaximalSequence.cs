using System;

class MaximalSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];

        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        int maxSeq = 1;
        int currSeq = 1;
        int number = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                currSeq++;
                if (currSeq > maxSeq)
                {
                    maxSeq = currSeq;
                    number = nums[i];
                }
            }
            else
            {
                currSeq = 1;
            }
        }
        Console.WriteLine(maxSeq);
    }
}

