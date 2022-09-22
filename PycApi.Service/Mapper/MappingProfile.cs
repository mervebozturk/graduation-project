using AutoMapper;
using PycApi.Data;
using PycApi.Dto;

namespace PycApi.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CategoryDto, Category>().ReverseMap();

            CreateMap<ProductDto, Product>().ReverseMap();

            CreateMap<UserDto, User>().ReverseMap();


        }
    }
}
