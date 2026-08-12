using AutoMapper;
using Dto;
using Entity.Models;

namespace StorageManager;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<Products, ProductDto>()
         .ForMember(
        dest => dest.groupName,
        opt => opt.MapFrom(src => src.groupOfProduct.groupName)
         );
    }
}