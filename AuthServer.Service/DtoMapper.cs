﻿using AuthServer.Core.Dtos;
using AuthServer.Core.Entities;
using AutoMapper;

namespace AuthServer.Service
{
    public class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<UserAppDto, UserApp>().ReverseMap();
        }
    }
}