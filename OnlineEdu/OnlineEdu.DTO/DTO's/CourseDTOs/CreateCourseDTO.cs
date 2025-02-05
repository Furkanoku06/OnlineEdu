﻿using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DTO.DTO_s.CourseDTOs
{
    public class CreateCourseDTO
    {
        public string CourseName { get; set; }
        public string ImageUrl { get; set; }
        public int CourseCategoryID { get; set; }
        public decimal Price { get; set; }
        public bool IsShown { get; set; }
    }
}
