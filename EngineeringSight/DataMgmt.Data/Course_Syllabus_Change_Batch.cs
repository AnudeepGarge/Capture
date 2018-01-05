using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMgmt.Data
{
    public class Course_Syllabus_Change_Batch 
    {
        public Course_Syllabus_Change_Batch()
        {
            BranchesInCourse = new HashSet<Course_Branch>();
        }
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int BatchId { get; set; }

        public University_Course Course { get; set; }
        public Batch Batch { get; set; }

        public ICollection<Course_Branch> BranchesInCourse { get; set; }
    }
}
