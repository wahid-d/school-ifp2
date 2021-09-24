using System;
using System.ComponentModel.DataAnnotations;

namespace lms.Models
{
    public abstract class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get => $"{FirstName} {LastName}"; }
        [Phone]
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age { get => getAge(Birthdate); }
        public EGender Gender { get; set; }

        [Obsolete("Cannot initialize empty Person", true)]
        public Person() { }

        public Person(
            string firstName,
            string lastName,
            string phone,
            string email,
            DateTime birthdate,
            EGender gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Birthdate = birthdate;
            Gender = gender;

            Id = Guid.NewGuid();
        }

        private int getAge(DateTime birthdate)
        {
            var span = DateTime.Now - birthdate;
            return (int)(span.TotalDays / 365);
        }

        public override string ToString()
        {
            return $"{Id} - {FullName} - {Age}";
        }
    }
}