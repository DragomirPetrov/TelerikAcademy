namespace Person
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var firstPerson = new Person("Mosiu Liukler", 76);
            var secondPerson = new Person("Pesho Peshev", 23);

            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
        }
    }
}