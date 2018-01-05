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
    public class Course_Syllabus_Change_BatchTypeConfiguration : EntityTypeConfiguration<Course_Syllabus_Change_Batch>
    {
        public Course_Syllabus_Change_BatchTypeConfiguration()
        {
            HasKey(item => item.Id);
            Property(item => item.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(item => item.Course).WithMany(item => item.Batches).HasForeignKey(item => item.CourseId);
            HasRequired(item => item.Batch).WithMany(item => item.SyllabusChangedCourses).HasForeignKey(item => item.BatchId);

            HasIndex(item => new { item.CourseId, item.BatchId }).IsUnique(true);

            HasMany(item => item.BranchesInCourse).WithRequired(item => item.Course).HasForeignKey(item => item.CourseId);
        }
	
    }
}
