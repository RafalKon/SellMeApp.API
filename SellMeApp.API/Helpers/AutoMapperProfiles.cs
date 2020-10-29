using AutoMapper;
using SellMeApp.API.Dtos;
using SellMeApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellMeApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
       public AutoMapperProfiles()
        {
            CreateMap<User,UserForListDto>();
            CreateMap<User, UserForDetailsDto>();
            CreateMap<UserForRegisterDto, User>();
            CreateMap<AuctionForCreateDto, Auction>();

        }
    }
}
