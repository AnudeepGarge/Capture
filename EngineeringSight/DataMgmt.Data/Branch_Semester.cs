using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMgmt.Data
{
    public class Branch_Semester
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int SemesterId { get; set; }
        public string BranchCode { get; set; }
        public Course_Branch Branch { get; set; }
        public Semester Semester { get; set; }

        public virtual ICollection<Subject_Semester> SubjectsInSemester { get; set; }
    }
}
