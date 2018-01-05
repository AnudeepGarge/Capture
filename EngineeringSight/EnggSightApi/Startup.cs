using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using DataMgmt.Buisness.Mappings;

[assembly: OwinStartup(typeof(EnggSightApi.Startup))]

namespace EnggSightApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Mapper.CreateMaps();
            ConfigureAuth(app);
        }
    }
}
