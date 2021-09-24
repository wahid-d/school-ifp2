using System;
using System.Collections.Generic;
using System.Linq;
using lms.Models;

namespace lms
{
    public class School
    {
        private readonly List<Student> students;
        private readonly List<Teacher> teachers;

        public School()
        {
            teachers = new List<Teacher>();
            students = new List<Student>();
        }

        public void AddStudent(Student student) => students.Add(student);
        public void AddTeacher(Teacher teacher) => teachers.Add(teacher);

        public List<Student> AllStudents() => students;
        public List<Teacher> AllTeachers() => teachers;

        public Student FindStudent(Guid id) => students.Where(s => s.Id == id).FirstOrDefault();
        public Teacher FindTeacher(Guid id) => teachers.Where(t => t.Id == id).FirstOrDefault();
        public List<Teacher> FindProfessors()
            => teachers.Where(t => t.Degree == Degree.PhD || t.Degree == Degree.PostDoc).ToList();
    }
}
