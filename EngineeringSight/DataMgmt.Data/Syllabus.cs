using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMgmt.Data
{
    public class Syllabus
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public DataCreationInfo CreationInfo { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
