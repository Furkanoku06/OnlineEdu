﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DTO.DTO_s.ContactDTOs
{
    public class UpdateContactDTO
    {
        public int ContactId { get; set; }
        public string MapUrl { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
