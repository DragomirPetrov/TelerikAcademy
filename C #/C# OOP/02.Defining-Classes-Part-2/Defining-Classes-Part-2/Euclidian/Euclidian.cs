namespace Euclidian
{
    using System;

    [Version(2, 11)]
    class StartUp
    {
        static Random rng = new Random();

        static void Main()
        {
            var type = typeof(StartUp);
            var attributes = type.GetCustomAttributes(false);

            foreach (VersionAttribute atr in attributes)
            {
                Console.WriteLine("Version: {0}", atr.Version);
            }

            GenericTest.MainTest(rng);
            MatrixTest.MainTest();
        }
    }
}