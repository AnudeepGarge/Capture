using DataMgmt.Buisness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMgmt.Buisness.Services
{
    public interface IUniversityMgmtService : IDisposable
    {
        IEnumerable<University> GetAll();
    }
}
