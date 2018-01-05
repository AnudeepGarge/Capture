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
    public class UniversityTypeConfiguration : EntityTypeConfiguration<University>
    {
        public UniversityTypeConfiguration()
        {
            HasKey(item => item.Id);
            //HasRequired(item => item.Name);
            Property(item => item.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(item => item.Name).IsRequired().HasMaxLength(63);

            HasMany(item => item.University_Courses).WithRequired(item => item.University).HasForeignKey(item => item.UniversityId);
            
        }
    }
}
