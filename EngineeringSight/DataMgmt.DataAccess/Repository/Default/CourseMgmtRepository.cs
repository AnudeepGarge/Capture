using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataMgmt.Data;

namespace DataMgmt.DataAccess.Repository.Default
{
    public class CourseMgmtRepository : WriteRepository<Context>, ICourseMgmtRepository
    {
        public IEnumerable<Course> GetItemsWithId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
