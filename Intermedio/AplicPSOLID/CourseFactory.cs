using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicPSOLID
{
    public class CourseFactory
    {
        public Course CreateCourse()
        {
            Console.Write("Ingrese el nombre del curso: ");
            string name = Console.ReadLine();
            Console.Write("Ingrese el tipo de curso (online/live): ");
            string type = Console.ReadLine();

            return new Course { Name = name, Type = type };
        }
    }

}
