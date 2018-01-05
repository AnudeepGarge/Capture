using DataMgmt.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMgmt.DataAccess.Configurations
{
    public class Course_BranchTypeConfiguration : EntityTypeConfiguration<Course_Branch>
    {
        private const string UNIQUE_INDEX = "Unique_KEY_Index";
        public Course_BranchTypeConfiguration()
        {
            HasKey(item => item.Id);
            Property(item => item.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //HasRequired(item => item.Branch).WithMany(item => item.CoursesInBranch).HasForeignKey(item => item.BranchId);
            //HasRequired(item => item.Course).WithMany(item => item.BranchesInCourse).HasForeignKey(item => item.CourseId);
            HasMany(item => item.BranchesOfSemester).WithRequired(item => item.Branch).HasForeignKey(item => item.BranchId);

            Property(item => item.CourseId).HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(new IndexAttribute(UNIQUE_INDEX, 1) { IsUnique = true }));

            Property(item => item.BranchId).HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(new IndexAttribute(UNIQUE_INDEX, 2) { IsUnique = true }));


            //HasIndex(item => new { item.CourseId, item.BranchId }).IsUnique().HasName("Course_Branch_Index"); ;
            
        }
	
    }
}
