using OnlineEdu.DTO.DTO_s.CourseDTOs;
using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DTO.DTO_s.CourseCategoryDTOs
{
    public class ResultCourseCategoryDTO
    {
        public int CourseCategoryId { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public bool IsShown { get; set; }
        public List<ResultCourseDTO> Courses { get; set; }
    }
}
