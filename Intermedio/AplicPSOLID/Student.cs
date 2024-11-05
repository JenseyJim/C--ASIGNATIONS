using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AplicPSOLID
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public List<Course> Courses { get; private set; }
        public Student(int studentId, string firstName, string lastName, DateTime dob, 
            string email, Address address)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            DoB = dob;
            Email = email;
            Address = address;
            Courses = new List<Course>();
        }
                public void AddCourse(Course course)
        {
            Courses.Add(course);
        }
    }

}
