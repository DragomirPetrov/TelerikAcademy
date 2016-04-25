using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double max = double.MinValue;
        double min = double.MaxValue;
        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            double currnet = double.Parse(Console.ReadLine());

            max = Math.Max(max, currnet);
            min = Math.Min(min, currnet);
            sum += currnet;
        }
        Console.WriteLine("min={0:F2}", min);
        Console.WriteLine("max={0:F2}", max);
        Console.WriteLine("sum={0:F2}", sum);
        double avg = sum / n;
        Console.WriteLine("avg={0:F2}", avg);
    }
}