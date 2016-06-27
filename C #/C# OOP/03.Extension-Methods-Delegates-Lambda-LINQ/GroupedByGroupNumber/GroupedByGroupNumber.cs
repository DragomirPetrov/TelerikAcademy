namespace GroupedByGroupNumber
{
    using System;
    using System.Linq;

    public class GroupedByGroupNumber
    {
        public static void Main()
        {
            var students = new[]
            {
                new { Name = "Jorkata", Group = "Informatics"},
                new { Name = "Kire", Group = "History"},
                new { Name = "Mara", Group = "Informatics"},
                new { Name = "Ickata", Group = "Mathematics"},
                new { Name = "Davidkata", Group = "History"},
                new { Name = "Igor", Group = "Mathematics"}
            };

            var groupedStudents = students.GroupBy(s => s.Group).OrderBy(g => g.Key);

            foreach (var group in groupedStudents)
            {
                foreach (var student in group)
                {
                    Console.WriteLine("{0} -> {1}", student.Group, student.Name);
                }
            }
        }
    }
}