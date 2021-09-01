using AZCORSSourceAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AZCORSSourceAPI.Service
{
    public class CourseService
    {
        List<Course> courselist;
        public CourseService()
        {
            courselist = new List<Course>()
            {
               new Course(){CourseID=100,CourseName="MCA"},
                new Course(){CourseID=101,CourseName="BCA"},
                 new Course(){CourseID=102,CourseName="B.SC"}
            };
        }
        public List<Course> GetCourses()
        {
            return  courselist;
        }
    }
}
