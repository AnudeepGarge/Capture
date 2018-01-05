﻿using DataMgmt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMgmt.DataAccess.Repository
{
    interface IUniversityManagementRepository : IWriteRepository
    {
        IEnumerable<University> GetAll();
    }
}
