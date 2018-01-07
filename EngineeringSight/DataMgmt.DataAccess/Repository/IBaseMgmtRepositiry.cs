using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMgmt.DataAccess.Repository
{
    public interface IBaseMgmtRepositiry<T> where T : class, new()
    {
        IEnumerable<T> GetItemsWithId(int id);
    }
}
