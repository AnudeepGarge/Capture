using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMgmt.DataAccess.Repository
{
    public interface IWriteRepository : IDisposable
    {
        T Insert<T>(T data, bool saveChanges = true) where T : class, new();
        T Delete<T>(T data, bool saveChanges = true) where T : class, new();
        T Update<T>(T data, bool saveChanges = true) where T : class, new();
        void SaveChanges();
    }
}
