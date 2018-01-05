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
    class Subject_SemesterTypeConfiguration : EntityTypeConfiguration<Subject_Semester>
    {
        public Subject_SemesterTypeConfiguration()
        {
            HasKey(item => item.Id);
            Property(item => item.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasIndex(item => new { item.SemesterId, item.SubjectId }).IsUnique(true);
        }

    }
}
