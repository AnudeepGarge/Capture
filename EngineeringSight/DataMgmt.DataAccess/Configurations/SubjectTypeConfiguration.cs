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
    public class SubjectTypeConfiguration : EntityTypeConfiguration<Subject>
    {
        public SubjectTypeConfiguration()
        {
            HasKey(item => item.Id);
            //HasRequired(item => item.Name);
            Property(item => item.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(item => item.Name).IsRequired().HasMaxLength(63);
            Property(item => item.SubjectCode).IsRequired().HasMaxLength(23);

            HasMany(item => item.SemestersHavingSubject).WithRequired(item => item.Subject).HasForeignKey(item => item.SubjectId);

            

        }
	
    }
}
