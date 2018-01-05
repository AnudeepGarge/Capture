using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMgmt.Data
{
    public class Semester
    {
        public Semester()
        {
            BranchesOfSemester = new HashSet<Branch_Semester>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DataCreationInfo CreationInfo { get; set; }
        public string Synonyms { get; set; }
        public ICollection<Branch_Semester> BranchesOfSemester { get; set; }
    }
}
