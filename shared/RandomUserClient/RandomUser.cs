using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using lms.Models;
using RandomUserClient.Dto;

namespace RandomUserClient
{
    public class RandomUser
    {
        private string _baseUrl;

        public RandomUser(string baseUrl)
        {
            _baseUrl = baseUrl;
        }


        public async Task<List<Student>> GetRandomStudents()
        {
            var httpClient = new HttpClient();
            var randomUsersString = await httpClient.GetStringAsync(_baseUrl);

            var randomUsers = JsonSerializer.Deserialize<RandomUserResponse>(randomUsersString);
            var students = new List<Student>();

            foreach(var user in randomUsers.Results)
            {
                var student = new Student
                    (
                        firstName: user.Name.First,
                        lastName: user.Name.Last,
                        phone: user.Phone,
                        email: user.Email,
                        birthdate: user.Dob.Date,
                        gender: convertGender(user.Gender),
                        score: new Random().Next(1, 101)
                    );
                students.Add(student);

                Console.WriteLine(student);
            }

            return students;
        }

        private EGender convertGender(string gender)
        {
            if(gender.ToLower() == $"{EGender.Male}".ToLower())
            {
                return EGender.Male;
            }
            else
            {
                return EGender.Female;
            }
        }
    }
}
