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

         CreateMap<GroupOfProductCreatDto,GroupOfProduct>();
         CreateMap<GroupOfProduct,GroupOfProductDto>().ReverseMap();
         CreateMap<GroupOfProduct,GroupOfProductDto>().ReverseMap();
         CreateMap<ProductAddDto,Products>();
         CreateMap<ProductAddDto,ProductDto>().ReverseMap();
    }
}