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
    public class BranchTypeConfiguration : EntityTypeConfiguration<Branch>
    {
        public BranchTypeConfiguration()
        {
            HasKey(item => item.Id);
            //HasRequired(item => item.Name);
            Property(item => item.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(item => item.Name).IsRequired().HasMaxLength(63);

            HasMany(item => item.CoursesInBranch).WithRequired(item => item.Branch).HasForeignKey(item => item.BranchId);
        }
	
    }
}
