using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicPSOLID
{
    public interface ISubscriptionService
    {
        IList<Course> Subscribe(Student student, Course course);
    }

}
