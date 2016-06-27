namespace School
{
    using Record;
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var nakovDisciplines = new List<Disciplines>
            {
                new Disciplines(DisciplineName.Math, 10, 10),
                new Disciplines(DisciplineName.Informatics, 20, 20)
            };

            var kiroDisciplines = new List<Disciplines>
            {
                new Disciplines(DisciplineName.History, 8, 8),
                new Disciplines(DisciplineName.Geography, 6, 6)
            };

            var studentsFirstClass = new List<Student>
            {
                new Student("Pavel", "Popandov"),
                new Student("Angel", "Demirev"),
                new Student("Meri", "Chleri")
            };

            var studentsSecondClass = new List<Student>
            {
                new Student("Ganka", "Peicheva"),
                new Student("Eskenazi", "Evtimov"),
                new Student("Grigor", "Markov")
            };

            var teachers = new List<Teacher>
            {
                new Teacher("Sun", "Tzu", nakovDisciplines),
                new Teacher("Dalai", "Lama", kiroDisciplines)
            };

            var firstClass = new SchoolClass(teachers, studentsFirstClass);
            var secondClass = new SchoolClass(teachers, studentsSecondClass);

            var school = new School(new List<SchoolClass> { firstClass, secondClass });

            Console.WriteLine(school);
        }
    }
}