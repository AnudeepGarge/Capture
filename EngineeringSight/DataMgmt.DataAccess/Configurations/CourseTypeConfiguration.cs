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
    public class CourseTypeConfiguration : EntityTypeConfiguration<Course>
    {
        public CourseTypeConfiguration()
        {
            HasKey(item => item.Id);
            Property(item => item.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(item => item.Name).IsRequired().HasMaxLength(63);
            Property(item => item.CourseCode).IsOptional().HasMaxLength(23);
            Property(item => item.Synonyms).HasMaxLength(31);

            HasMany(item => item.University_Courses).WithRequired(item => item.Course).HasForeignKey(item => item.CourseId);
        }
	
    }
}
