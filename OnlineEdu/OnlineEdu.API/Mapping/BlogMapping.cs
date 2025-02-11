﻿using AutoMapper;
using OnlineEdu.DTO.DTO_s.BlogDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class BlogMapping : Profile
    {
        public BlogMapping()
        {
            CreateMap<CreateBlogDTO, Blog>().ReverseMap();
            CreateMap<UpdateBlogDTO, Blog>().ReverseMap();
            CreateMap<ResultBlogDTO, Blog>().ReverseMap();
        }
    }
}
