using System;

namespace lms.Models
{
    public class Student : Person
    {
        public int Score { get; set; }
        public char Grade
        {
            get => Score switch
            {
                >= 90 => 'A',
                >= 80 => 'B',
                >= 70 => 'C',
                >= 60 => 'D',
                _ => 'F'
            };
        }

        public Student(
            string firstName,
            string lastName,
            string phone,
            string email,
            DateTime birthdate,
            EGender gender,
            int score)
            : base(firstName, lastName, phone, email, birthdate, gender)
        {
            Score = score;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - {Grade}";
        }
    }
}