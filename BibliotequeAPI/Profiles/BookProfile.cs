using AutoMapper;
using BibliotequeAPI.DTO.Books;
using BibliotequeAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotequeAPI.Profiles
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<BookModel, BookReadDTO>();
            CreateMap<BookCreateDTO, BookModel>();
        }
    }
}
