using AutoMapper;
using OnlineEdu.DTO.DTO_s.AboutDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            CreateMap<CreateAboutDTO,About>().ReverseMap();
            CreateMap<UpdateAboutDTO,About>().ReverseMap();
        }
    }
}
