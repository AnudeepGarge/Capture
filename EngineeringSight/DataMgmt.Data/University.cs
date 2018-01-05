using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMgmt.Data
{
    public class University
    {
        public University()
        {
            University_Courses = new HashSet<University_Course>();
        }

        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public DataCreationInfo CreationInfo { get; set; }

        public virtual ICollection<University_Course> University_Courses { get; set; }
    }
}
