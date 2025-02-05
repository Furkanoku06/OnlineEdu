using AutoMapper;
using OnlineEdu.DTO.DTO_s.CourseCategoryDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class CourseCategoryMapping : Profile
    {
        public CourseCategoryMapping()
        {
            CreateMap<CreateCourseCategoryDTO, CourseCategory>().ReverseMap();
            CreateMap<UpdateCourseCategoryDTO, CourseCategory>().ReverseMap();
            CreateMap<ResultCourseCategoryDTO, CourseCategory>().ReverseMap();
        }
    }
}
