using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMgmt.Data
{
    public class Subject_Semester
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int SemesterId { get; set; }

        public Subject Subject { get; set; }

        public Branch_Semester Semester { get; set; }

    }
}
