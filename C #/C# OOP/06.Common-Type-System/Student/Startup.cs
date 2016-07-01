namespace Student
{
    using System;

    class Startup
    {
        static void Main()
        {
            var firstStudent = new Student("Margaritka", "Detelinova", "Cvetanova", "903-110-5516", "Plovdiv", "0876886192",
           "margaritka@abv.bg", 4, Universities.PlovdivUniversity, Faculties.PhilologyFaculty, Specialties.Philology);

            var secondStudent = new Student("Martin", "Evlogiev", "Popandov", "107-25-1756", "Mladost 1", "0889465432",
           "martenceto88@yahoo.com", 4, Universities.SofiaUniversity, Faculties.FMI, Specialties.SoftwareEngineer);

            var thirdStudent = new Student("Zlati", "Zlatev", "Zlatistia", "991-03-1653", "Zlatnite mostove", "08986112131",
           "zlatistia@hotmail.com", 4, Universities.TechnicalUniversity, Faculties.TransportFaculty, Specialties.TransportEngineer);

            bool compareFirstAndSecond = firstStudent.Equals(secondStudent);
            bool compareFirstAndThird = firstStudent.Equals(thirdStudent);
            bool operatorsCompareFirstAndSecond = firstStudent == secondStudent;
            bool operatorsCompareFirstAndThird = firstStudent != thirdStudent;
            var hashCodeTest = firstStudent.GetHashCode();


            Console.WriteLine(firstStudent + "\n");
            Console.WriteLine(secondStudent + "\n");
            Console.WriteLine(thirdStudent + "\n");

            Console.WriteLine("Compare first and second with Equals: {0}", compareFirstAndSecond);
            Console.WriteLine("Compare first and third with Equals: {0}\n", compareFirstAndThird);

            Console.WriteLine("Compare first and second with == {0}", operatorsCompareFirstAndSecond);
            Console.WriteLine("Compare first and third with == {0}\n", operatorsCompareFirstAndThird);

            Console.WriteLine("Compare first and second with CompareTo: {0}", firstStudent.CompareTo(secondStudent));
            Console.WriteLine("Compare first and third with CompareTo: {0}\n", firstStudent.CompareTo(thirdStudent));

            var cloned = thirdStudent.Clone() as Student;

            Console.WriteLine("Cloned == thirdStudent? {0}", cloned == thirdStudent);
            thirdStudent = secondStudent;
            Console.WriteLine("Cloned == thirdStudent? after swapping? {0}", cloned == thirdStudent);
        }
    }
}
