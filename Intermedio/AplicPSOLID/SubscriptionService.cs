using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicPSOLID
{
    public class SubscriptionService : ISubscriptionService
    {
        public IList<Course> Subscribe(Student student, Course course)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Starting Subscribe()");
            student.AddCourse(course); 
            Console.WriteLine("End Subscribe()");
            return student.Courses;
        }
    }


}
