using DataMgmt.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMgmt.DataAccess.Configurations
{
    public class UnitTypeConfiguration : EntityTypeConfiguration<Unit>
    {
        public UnitTypeConfiguration()
        {
            HasKey(item => item.Id);
            Property(item => item.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(item => item.Title).HasMaxLength(127).IsRequired();
            HasRequired(item => item.Subject).WithMany(item => item.Units).HasForeignKey(item => item.SubjectId);
        }
	
    }
}
