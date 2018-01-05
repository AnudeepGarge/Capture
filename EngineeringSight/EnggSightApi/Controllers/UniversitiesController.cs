using DataMgmt.Buisness.Model;
using DataMgmt.Buisness.Services.Default;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EnggSightApi.Controllers
{
    public class UniversitiesController : ApiController
    {
        public IEnumerable<University> Get()
        {
            IEnumerable<University> universities = null;
            using (var context = new UniversityMgmtService())
            {
                universities = context.GetAll().ToList();
            }
            return universities;
        }
    }
}
