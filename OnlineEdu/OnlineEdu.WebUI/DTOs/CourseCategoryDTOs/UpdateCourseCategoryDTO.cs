﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.WebUI.DTOs.CourseCategoryDTOs
{
    public class UpdateCourseCategoryDTO
    {
        public int CourseCategoryId { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public bool IsShown { get; set; }
    }
}
