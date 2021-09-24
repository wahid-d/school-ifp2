using System;

namespace lms.Models
{
    public class Teacher : Person
    {
        public Degree Degree { get; set; }
        public string Subject { get; set; }

        public Teacher(
            string firstName,
            string lastName,
            string phone,
            string email,
            DateTime birthdate,
            EGender gender,
            Degree degree,
            string subject)
            : base(firstName, lastName, phone, email, birthdate, gender)
        {
            Degree = degree;
            Subject = subject;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - {Degree}";
        }
    }
}