using AutoMapper;
using BookManagementAPI.Data;
using BookManagementAPI.Models.Dtos.AuthorDto;

namespace BookManagementAPI.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            // Author Dtos
            CreateMap<Author, CreateAuthorDto>().ReverseMap();
            CreateMap<Author, GetAuthorDto>().ReverseMap();
            CreateMap<Author,  UpdateAuthorDto>().ReverseMap();
            CreateMap<Author, AuthorDto>().ReverseMap();
        }
    }
}
