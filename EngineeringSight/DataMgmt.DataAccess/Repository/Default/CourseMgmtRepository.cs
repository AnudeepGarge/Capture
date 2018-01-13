using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataMgmt.Data;

namespace DataMgmt.DataAccess.Repository.Default
{
    public class CourseMgmtRepository : WriteRepository<Context>, ICourseMgmtRepository
    {
        public IEnumerable<Course> GetItemsWithId(int id)
        {
            IEnumerable<Course> courses = null;
            courses = (from university in Context.University
                      join unv_course in Context.University_Course on university.Id equals unv_course.UniversityId
                      where university.Id == id
                      select unv_course.Course).ToList();

            return courses;
        }
    }
}
