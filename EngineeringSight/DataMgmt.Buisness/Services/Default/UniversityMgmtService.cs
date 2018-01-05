using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataMgmt.Buisness.Model;
using DataMgmt.DataAccess.Repository.Default;
using DataMgmt.DataAccess.Repository;
using AutoMapper;

namespace DataMgmt.Buisness.Services.Default
{
    public class UniversityMgmtService : IUniversityMgmtService
    {
        private IUniversityManagementRepository _mgmtService;
        public UniversityMgmtService()
        {
            _mgmtService = new UniversityManagementRepository();
        }

        public IEnumerable<University> GetAll()
        {
            return _mgmtService.GetAll().Select(Mapper.Map<DataMgmt.Data.University, University>);
        }

        public void Dispose()
        {
            _mgmtService.Dispose();
        }
    }
}
