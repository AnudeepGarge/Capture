using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMgmt.Data
{
    public class Course_Branch
    {
        public Course_Branch()
        {
        }

        public int Id { get; set; }
        public int CourseId { get; set; }
        public int BranchId { get; set; }
        public string BranchCode { get; set; }
        public Course_Syllabus_Change_Batch Course { get; set; }
        public Branch Branch { get; set; }
        public ICollection<Branch_Semester> BranchesOfSemester { get; set; }
    }
}
