using DataMgmt.Buisness.Model;
using DataMgmt.Buisness.Services.Default;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace EnggSightApi.Controllers
{
    public class CourseController : ApiController
    {
        // GET: Course
        public IEnumerable<Course> Get(int id)
        {
            IEnumerable<Course> courses = null;
            using (var context = new CourseMgmtService())
            {
                courses = context.GetCoursesById(id).ToList();
            }
            return courses;
        }
    }
}