namespace OrderStudents
{
    using System;
    using System.Linq;

    public class OrderStudents
    {
        public static void Main()
        {
            var arrayOfStudents = new[]
            {
                new { FirstName = "Pesho", LastName = "Peshev" },
                new { FirstName = "Gabriel", LastName = "Batistuta" },
                new { FirstName = "Bogdan", LastName = "Stanko" },
                new { FirstName = "Ricardo", LastName = "Sanches" },
                new { FirstName = "Emanuel", LastName = "Grozev"}
            };

            var sortedStudents = arrayOfStudents.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.LastName);

            Console.WriteLine("Sorted by descending first name then by descending last name:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}