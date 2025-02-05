using AutoMapper;
using OnlineEdu.DTO.DTO_s.SocialMedyaDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class SocialMediaMapping : Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<CreateSocialMediaDTO,SocialMedia>().ReverseMap();
            CreateMap<UpdateSocialMediaDTO,SocialMedia>().ReverseMap();

        }
    }
}
