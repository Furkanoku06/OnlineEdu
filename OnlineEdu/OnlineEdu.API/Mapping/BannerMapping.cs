using AutoMapper;
using OnlineEdu.DTO.DTO_s.BannerDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class BannerMapping : Profile
    {
        public BannerMapping()
        {
            CreateMap<CreateBannerDTO,Banner>().ReverseMap();
            CreateMap<UpdateBannerDTO,Banner>().ReverseMap();
        }
    }
}
