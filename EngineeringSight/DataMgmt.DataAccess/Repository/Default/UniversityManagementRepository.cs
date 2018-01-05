using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataMgmt.Data;

namespace DataMgmt.DataAccess.Repository.Default
{
    public class UniversityManagementRepository : WriteRepository<Context>, IUniversityManagementRepository
    {
        
        #region Constants and Enums

        #endregion

        #region Private and Protected Member Variables 

        #endregion

        #region Private and Protected Methods

        #endregion

        #region Constructors
       
        #endregion

        #region Public Properties

        #endregion

        #region Public Methods
        public IEnumerable<University> GetAll()
        {
            IEnumerable<University> universities = null;
            universities = Context.University.ToList();

            return universities;
        }
        #endregion

    }
}
