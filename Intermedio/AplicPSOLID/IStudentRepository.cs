using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicPSOLID
{
    public interface IStudentRepository
    {
        void Save(Student student);
        void Delete(Student student);
    }

}
