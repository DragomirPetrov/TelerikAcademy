using System;

class SquareRoot
{
    static void Main()
    {
        string bye = "Good bye";
        string invalid = "Invalid number";

        try
        {
            var input = double.Parse(Console.ReadLine());
            var sqrt = Math.Sqrt(input).ToString("F3");

            if (sqrt == "NaN")
            {
                throw new FormatException();
            }
            else
            {
                Console.WriteLine(sqrt);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine(invalid);
        }
        finally
        {
            Console.WriteLine(bye);
        }
    }
}