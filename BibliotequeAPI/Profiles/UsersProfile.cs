using AutoMapper;
using BibliotequeAPI.DTO;
using BibliotequeAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotequeAPI.Profiles
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<UserModel, UserReadDTO>();
            CreateMap<UserCreateDTO, UserModel>();
            CreateMap<UserUpdateDTO, UserModel>();
        } 
    }
}
