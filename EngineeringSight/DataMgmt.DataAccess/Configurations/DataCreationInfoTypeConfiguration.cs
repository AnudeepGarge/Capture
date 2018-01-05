using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using DataMgmt.Data;

namespace DataMgmt.DataAccess.Configurations
{
    public class DataCreationInfoTypeConfiguration : ComplexTypeConfiguration<DataCreationInfo>
    {
        public DataCreationInfoTypeConfiguration()
        {
            Property(item => item.Description).IsRequired().HasMaxLength(127);
        }
	
    }
}
