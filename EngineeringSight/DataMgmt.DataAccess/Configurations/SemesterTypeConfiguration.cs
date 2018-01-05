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
    public class SemesterTypeConfiguration : EntityTypeConfiguration<Semester>
    {
        public SemesterTypeConfiguration()
        {
            HasKey(item => item.Id);
            //HasRequired(item => item.Name);
            Property(item => item.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(item => item.Name).IsRequired().HasMaxLength(63);

            Property(item => item.Synonyms).HasMaxLength(31);

            HasMany(item => item.BranchesOfSemester).WithRequired(item => item.Semester).HasForeignKey(item => item.SemesterId);
        }
	
    }
}
