namespace RangeExceptions
{
    using System;

    public class Test
    {
        public static void Main()
        {
            Console.WriteLine();

            var min = DateTime.ParseExact("11-03-1960", "dd-MM-yyyy", null);
            var max = DateTime.ParseExact("14-04-2017", "dd-MM-yyyy", null);

            var teste = new InvalidRangeException<DateTime>("unsuccessful",
                    DateTime.ParseExact("04-11-1870", "dd-MM-yyyy", null),
                    DateTime.ParseExact("14-04-2017", "dd-MM-yyyy", null));

            var test = DateTime.Parse("7.9.1943");
            try
            {
                Validate.ValidateDataInRange(test, min, max);
            }
            catch (InvalidRangeException<DateTime> e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
