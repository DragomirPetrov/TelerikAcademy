using System;

namespace _08.EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string firstName = (Console.ReadLine());
            string lastName = (Console.ReadLine());
            byte age = byte.Parse(Console.ReadLine());
            string gender = (Console.ReadLine());
            long idNumber = long.Parse(Console.ReadLine());
            ulong employeeNumber = ulong.Parse(Console.ReadLine());

            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " + lastName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Personal ID number: " + idNumber);
            Console.WriteLine("Unique employee number: " + employeeNumber);
        }
    }
}
