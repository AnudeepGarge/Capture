using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMgmt.Data
{
    public class Branch
    {
        public Branch()
        {
            CreationInfo = new DataCreationInfo();
            CoursesInBranch = new HashSet<Course_Branch>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DataCreationInfo CreationInfo { get; set; }
        public ICollection<Course_Branch> CoursesInBranch { get; set; }
    }
}
