using DataMgmt.Data;
using DataMgmt.DataAccess.Configurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMgmt.DataAccess
{
    public class Context : DbContext
    {
        public Context(): base("Name=EngineeringDataMgmtDatabase")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add<DataCreationInfo>(new DataCreationInfoTypeConfiguration());
            modelBuilder.Configurations.Add<University>(new UniversityTypeConfiguration());
            modelBuilder.Configurations.Add<Course>(new CourseTypeConfiguration());
            modelBuilder.Configurations.Add<University_Course>(new University_CourseTypeConfiguration());
            modelBuilder.Configurations.Add<Branch>(new BranchTypeConfiguration());
            modelBuilder.Configurations.Add<Course_Branch>(new Course_BranchTypeConfiguration());
            modelBuilder.Configurations.Add<Semester>(new SemesterTypeConfiguration());
            modelBuilder.Configurations.Add<Branch_Semester>(new Branch_SemesterTypeConfiguration());
            modelBuilder.Configurations.Add<Batch>(new BatchTypeConfiguration());
            modelBuilder.Configurations.Add<Course_Syllabus_Change_Batch>(new Course_Syllabus_Change_BatchTypeConfiguration());
            modelBuilder.Configurations.Add<Subject>(new SubjectTypeConfiguration());
            modelBuilder.Configurations.Add<Subject_Semester>(new Subject_SemesterTypeConfiguration());
            modelBuilder.Configurations.Add<Unit>(new UnitTypeConfiguration());
            modelBuilder.Configurations.Add<Syllabus>(new SyllabusTypeConfiguration());
        }

        public DbSet<University> University { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<University_Course> University_Course { get; set; }
        public DbSet<Course_Branch> Course_Branch { get; set; }
        public DbSet<Batch> Batch { get; set; }
        public DbSet<Course_Syllabus_Change_Batch> Course_Batch { get; set; }
        public DbSet<Semester> Semester { get; set; }
        public DbSet<Branch_Semester> Branch_Semester { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Subject_Semester> SubjectSemester { get; set; }

        public DbSet<Unit> Unit { get; set; }

        public DbSet<Syllabus> Syllabus { get; set; }

    }
}
