using OnlineEdu.DTO.DTO_s.BlogDTOs;
using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DTO.DTO_s.BlogCategoryDTOs
{
    public class UpdateBlogCategoryDTO
    {
        public int BlogCategoryId { get; set; }
        public string Name { get; set; }
    }
}
