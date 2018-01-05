using DataMgmt.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMgmt.DataAccess.Configurations
{
    public class BatchTypeConfiguration : EntityTypeConfiguration<Batch>
    {
        public BatchTypeConfiguration()
        {
            Property(item => item.Description).IsRequired().HasMaxLength(127);
        }
	
    }
}
