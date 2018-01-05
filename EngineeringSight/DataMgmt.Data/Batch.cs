using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMgmt.Data
{
    public class Batch
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }

        public ICollection<Course_Syllabus_Change_Batch> SyllabusChangedCourses { get; set; }

    }
}
