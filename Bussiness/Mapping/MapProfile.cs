using AutoMapper;
using Entities;
using Entities.DTOs;
using Entities.Models;

namespace Bussiness.Mapping
{
    public class MapProfile : Profile
    {

        public MapProfile() { 
        
            CreateMap<User,UserDtos>().ReverseMap();
            CreateMap<Communication, CommunicationDtos>().ReverseMap();
            CreateMap<Request, RequestDtos>().ReverseMap();
            CreateMap<House,HouseDtos>().ReverseMap();
            CreateMap<Address, AddressDtos>().ReverseMap();
            CreateMap<User,UserWithCommunicationDtos>().ReverseMap();
            CreateMap<Image, ImageDtos>().ReverseMap();
            CreateMap<House, HouseWithImagesWithAddressDtos>().ReverseMap();
        }

    }
}
