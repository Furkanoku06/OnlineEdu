using OnlineEdu.WebUI.DTOs.CourseCategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.WebUI.DTOs.CourseDTOs
{
    public class ResultCourseDTO
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string ImageUrl { get; set; }
        public int CourseCategoryID { get; set; }
        public ResultCourseCategoryDTO Category { get; set; }
        public decimal Price { get; set; }
        public bool IsShown { get; set; }
    }
}
