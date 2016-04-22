using System;

namespace _10.NullValuesArithmetic
{
    class NullValues
    {
        static void Main()
        {
            int? var = null;
            double? var2 = null;
            Console.WriteLine("Null intiger: " + var);
            Console.WriteLine("Null double: " + var2);
            var = 5;
            var2 = 6.6;
            Console.WriteLine("Value added to intiger: " + var);
            Console.WriteLine("Value added to double: " + var2);
        }
    }
}
