﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.WebUI.DTOs.BannerDTOs
{
    public class UpdateBannerDTO
    {
        public int BannerId { get; set; }
        public string Title { get; set; }
        public string İmageUrl { get; set; }
    }
}
