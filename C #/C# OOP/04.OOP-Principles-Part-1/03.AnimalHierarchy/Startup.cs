namespace AnimalHierarchy
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            Animal[] animals =
            {
                new Dog("Rex", Gender.Male, 9),
                new Dog("Betoven", Gender.Male, 7),
                new Dog("Sara", Gender.Female, 4),

                new Frog("Jorko", Gender.Male, 6),
                new Frog("Gecata", Gender.Female, 1),
                new Frog("Kurmit", Gender.Male, 3),

                new Cat("Aristotel", Gender.Male, 8),
                new TomCat("Tom", 8),
                new Kitten("Princess",  1)
            };

            Console.WriteLine(Animal.AverageAge(animals));
            Console.WriteLine();

            foreach (var animal in animals)
            {
                Console.Write("{0} says: ", animal.Name);
                animal.MakeSound();
            }
        }
    }
}