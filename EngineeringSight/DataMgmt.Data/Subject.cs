using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMgmt.Data
{
    public class Subject
    {
        public Subject()
        {
            SemestersHavingSubject = new HashSet<Subject_Semester>();
            Units = new HashSet<Unit>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string SubjectCode { get; set; }
        public DataCreationInfo CreationInfo { get; set; }

        public virtual ICollection<Subject_Semester> SemestersHavingSubject { get; set; }

        public virtual ICollection<Unit> Units { get; set; }
    }
}
