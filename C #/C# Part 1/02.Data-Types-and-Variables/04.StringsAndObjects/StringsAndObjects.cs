using System;

namespace _04.StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World.";
            object result = (hello + " " + world);
            Console.WriteLine(result);
        }
    }
}
