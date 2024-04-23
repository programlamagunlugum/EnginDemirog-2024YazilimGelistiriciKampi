using Giris.DataAccess.Abstracts;
using Giriş.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giris.DataAccess.Concretes
{
    public class CourseDal:ICourseDal
    {
        List<Course> courses;
        public CourseDal()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "c#";
            course1.Prices = 10;
            course1.Description = ".Net ...";

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "c#";
            course2.Prices = 10;
            course2.Description = ".Net ...";

            courses = new List<Course> { course1, course2 };
        }
        public List<Course> GetAll()
        {
            return courses;
        }
        public void Add(Course course)
        {
            courses.Add(course);
        }
    }
}
