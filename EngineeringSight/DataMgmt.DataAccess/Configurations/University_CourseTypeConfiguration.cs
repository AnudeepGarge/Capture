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
    public class University_CourseTypeConfiguration : EntityTypeConfiguration<University_Course>
    {
        private const string UNIQUE_INDEX = "University_CourseIndex";
        public University_CourseTypeConfiguration()
        {
            HasKey(item => item.Id);
            Property(item => item.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //HasRequired(item => item.University).WithMany(item => item.University_Courses).HasForeignKey(item => item.UniversityId);
            //HasRequired(item => item.Course).WithMany(item => item.University_Courses).HasForeignKey(item => item.CourseId);

            Property(item => item.UniversityId).HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(new IndexAttribute(UNIQUE_INDEX, 1) { IsUnique = true }));

            Property(item => item.CourseId).HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(new IndexAttribute(UNIQUE_INDEX, 2) { IsUnique = true }));

            HasMany(item => item.Batches).WithRequired(item => item.Course).HasForeignKey(item => item.CourseId);

        }
	
    }
}
