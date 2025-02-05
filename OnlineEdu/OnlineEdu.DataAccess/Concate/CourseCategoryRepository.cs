using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.DataAccess.Context;
using OnlineEdu.DataAccess.Repositories;
using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DataAccess.Concate
{
    public class CourseCategoryRepository : GenreciRepository<CourseCategory>, ICourseCategoryRepository
    {
        public CourseCategoryRepository(OnlineEduContext _context) : base(_context)
        {
        }

        public void DontShowOnHome(int id)
        {
            var value = _context.Courses.Find(id);
            value.IsShown = false;
            _context.SaveChanges();
        }

        public void ShowOnHome(int id)
        {
            var value = _context.Courses.Find(id);
            value.IsShown = true;
            _context.SaveChanges();
        }
    }
}
