using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMgmt.Buisness.Model
{
    public class University
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long CreatedOn { get; set; }
        public long UpdatedOn { get; set; }
        public string Description { get; set; }

    }
}
