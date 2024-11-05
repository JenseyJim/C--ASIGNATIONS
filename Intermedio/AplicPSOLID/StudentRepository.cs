using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicPSOLID
{
    public class StudentRepository : IStudentRepository
    {
        public void Save(Student student)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Starting Save()");
            
            Console.WriteLine("End Save()");
        }

        public void Delete(Student student)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Starting Delete()");
            
            Console.WriteLine("End Delete()");
        }
    }

}
