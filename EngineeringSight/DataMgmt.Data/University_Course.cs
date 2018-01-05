using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMgmt.Data
{
    public class University_Course
    {
        public University_Course()
        {
            Batches = new HashSet<Course_Syllabus_Change_Batch>();
        }

        public int Id { get; set; }
        public int CourseId { get; set; }
        public int UniversityId { get; set; }
        public string CourseCode { get; set; }
        public Course Course { get; set; }
        public University University { get; set; }
       
        public ICollection<Course_Syllabus_Change_Batch> Batches { get; set; }
    }
}
