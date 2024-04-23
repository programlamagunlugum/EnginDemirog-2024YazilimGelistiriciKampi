using Giris.DataAccess.Abstracts;
using Giris.DataAccess.Concretes;
using Giriş.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giriş.Business
{
    public class CourseManager
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(CourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public CourseDal CourseDal { get; }

        public List<Course> GetAll()
        {
           
            return _courseDal.GetAll();
        }
    }
}
