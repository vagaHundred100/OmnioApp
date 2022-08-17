using AutoMapper;
using BLL.Autorization.Abstract;
using BLL.Autorization.Concrete;
using BLL.DTO;
using DAL.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Helpers.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<RegisterDTO, User>();
            CreateMap<User,UserClaimsOptions>();
            CreateMap<UpdateDTO, User>();
            CreateMap<User, UserIndexDTO>();
            CreateMap<Message, MessageReadDTO>();
        }

    }
}
