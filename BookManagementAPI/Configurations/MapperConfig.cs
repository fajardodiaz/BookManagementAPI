using AutoMapper;
using BookManagementAPI.Data;
using BookManagementAPI.Models.Dtos.AuthorDto;
using BookManagementAPI.Models.Dtos.Category;
using BookManagementAPI.Models.Dtos.PublisherDto;

namespace BookManagementAPI.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            // Author Dtos
            CreateMap<Author, AuthorDto>().ReverseMap();
            CreateMap<Author, CreateAuthorDto>().ReverseMap();
            CreateMap<Author, GetAuthorDto>().ReverseMap();
            CreateMap<Author, UpdateAuthorDto>().ReverseMap();

            // Publisher Dtos
            CreateMap<Publisher, PublisherDto>().ReverseMap();
            CreateMap<Publisher, CreatePublisherDto>().ReverseMap();
            CreateMap<Publisher, GetPublisherDto>().ReverseMap();
            CreateMap<Publisher, UpdateAuthorDto>().ReverseMap();

            // Category Dtos
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
        }
    }
}
