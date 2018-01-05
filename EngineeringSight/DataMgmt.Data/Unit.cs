using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMgmt.Data
{
    public class Unit
    {
        public int Id { get; set; }
        public string Title { get; set; }        
        public DataCreationInfo CreationInfo { get; set; }
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Syllabus Syllabus { get; set; }
    }
}
