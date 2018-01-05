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
    public class Branch_SemesterTypeConfiguration : EntityTypeConfiguration<Branch_Semester>
    {
        private const string UNIQUE_INDEX = "Unique_KEY_Index";
        public Branch_SemesterTypeConfiguration()
        {
            HasKey(item => item.Id);
            Property(item => item.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //Property(item => item.BranchId).HasColumnAnnotation(IndexAnnotation.AnnotationName,
            //    new IndexAnnotation(new IndexAttribute(UNIQUE_INDEX, 1) { IsUnique = true }));

            //Property(item => item.SemesterId).HasColumnAnnotation(IndexAnnotation.AnnotationName,
            //    new IndexAnnotation(new IndexAttribute(UNIQUE_INDEX, 2) { IsUnique = true }));

            HasIndex(item => new { item.BranchId, item.SemesterId }).IsUnique();

            HasMany(item => item.SubjectsInSemester).WithRequired(item => item.Semester).HasForeignKey(item => item.SemesterId);
            
        }
	
    }
}
