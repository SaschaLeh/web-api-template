using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class CourseStudent
    {
        public Guid CoursesId { get; set; }  
        public Guid StudentsId { get; set; }
    }
}
