using System;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double sum = 1;


        long factorialN = 1;
        for (long i = 1; i <= n ; i++)
        {
            
            factorialN *= i;
            
            sum += factorialN / Math.Pow(x, i);
            
        }
        Console.WriteLine("{0:F5}", sum);        
    }
}