using System;
using System.Threading.Tasks;
using lms.Models;
using RandomUserClient;

namespace lms
{
    class Program
    {
        static string url = "https://randomuser.me/api";
        static async Task Main()
        {
            var randomUserClient = new RandomUser(url);
            await randomUserClient.GetRandomStudents();

            Console.Read();
        }


        static void Main1(string[] args)
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
