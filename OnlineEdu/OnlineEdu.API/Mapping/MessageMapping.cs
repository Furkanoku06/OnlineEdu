﻿using AutoMapper;
using OnlineEdu.DTO.DTO_s.MessageDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class MessageMapping : Profile
    {
        public MessageMapping()
        {
            CreateMap<CreateMessageDTO,Message>().ReverseMap();
            CreateMap<UpdateMessageDTO,Message>().ReverseMap();
        }
    }
}
