using System;
using lms.Models;

namespace lms
{
    class Program
    {
        static void Main(string[] args)
        {
            var teshavoy = new Student(
                "Teshavoy",
                "Eshmatov",
                "+998931232222",
                "teshavoy@media.com",
                DateTime.Now.AddYears(new Random().Next(-70, -15)),
                EGender.Male,
                new Random().Next(101));

            Console.WriteLine(teshavoy);

            var school = new School();
            school.AddStudent(teshavoy);
        }

        // TODO: Student getRandomStudent()
        // TODO: Teacher getRandomTeacher()


    }
}
