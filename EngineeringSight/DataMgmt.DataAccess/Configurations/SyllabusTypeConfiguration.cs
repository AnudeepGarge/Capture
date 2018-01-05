using DataMgmt.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMgmt.DataAccess.Configurations
{
    public class SyllabusTypeConfiguration : EntityTypeConfiguration<Syllabus>
    {
        public SyllabusTypeConfiguration()
        {

            Property(item => item.Title).HasMaxLength(127).IsRequired();
            
            Property(item => item.Detail).HasMaxLength(2047).IsRequired();

            HasKey(item => item.Id).HasRequired(m => m.Unit).WithRequiredDependent(item => item.Syllabus).WillCascadeOnDelete();
        }

    }
}
