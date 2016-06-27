namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var students = new List<Student>
            {
                new Student("Dinko", "Georgiev", 5.50),
                new Student("Vasil", "Naidenov", 4.75),
                new Student("Stamat", "Kerchev", 5.75),
                new Student("Svetlana", "Aleksandrova", 4.25),
                new Student("Asen", "Blatechki", 5.10),
                new Student("Mariika", "Todorova", 6.00),
                new Student("Miho", "Mihov", 3.80),
                new Student("Kostadinka", "Markova", 5.30),
                new Student("Albena", "Ivanova", 4.10),
                new Student("Mitko", "Shterev", 5.60)
            };

            var orderByGrade = students.OrderBy(x => x.Grade);

            foreach (var student in orderByGrade)
            {
                Console.WriteLine("Name: {0} {1} | Grade: {2:F2}", student.FirstName, student.LastName, student.Grade);
            }

            Console.WriteLine();

            var workers = new List<Worker>
            {
                new Worker("Penko", "Penkov", 500, 10),
                new Worker("Jekata", "Dimitrov", 400, 12),
                new Worker("Svetlin", "Lozev", 1200, 8),
                new Worker("Martin", "Stanev", 3000, 12),
                new Worker("Hristo", "Petrov", 5000, 8),
                new Worker("Bojurka", "Metodieva", 600, 12),
                new Worker("Sali", "Spektra", 450, 10),
                new Worker("Rich", "Forester", 900, 12),
                new Worker("Igor", "Michels", 1600, 4),
                new Worker("Osvaldo", "Rios", 1000, 10)
            };

            var sortedByMoney = workers.OrderByDescending(x => x.MoneyPerHour());

            foreach (var worker in sortedByMoney)
            {
                Console.WriteLine("Name: {0} {1} | Money per hour: {2:F2}", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }

            Console.WriteLine();
            Console.WriteLine("Sorted by first and last name:");
            Console.WriteLine();

            var merged = students.Concat<Human>(workers).OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach (var person in merged)
            {
                Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
            }
        }
    }
}