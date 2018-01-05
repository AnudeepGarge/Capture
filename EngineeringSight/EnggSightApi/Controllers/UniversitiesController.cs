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
        public IEnumerable<string> Get()
        {
            return new List<string> { "VTU", "ANNA"};
        }
    }
}
