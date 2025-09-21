using AutoMapper;
using Bazar.Application.DTOs;
using Bazar.Domain.Entitis;
namespace Bazar.Application.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Electronics,ElectronicsDto>().ReverseMap();
            CreateMap<Books,BooksDto>().ReverseMap();
            CreateMap<Animals,AnimalsDto>().ReverseMap();
            CreateMap<Sports, SportsDto>().ReverseMap();
            CreateMap<Furniture,FurnitureDto>().ReverseMap();
            CreateMap<Kitchen,KitchenDto>().ReverseMap();
            CreateMap<Advertisements,AdvertisementsDto>().ReverseMap();
            CreateMap<Category,CategoryDto>().ReverseMap();
            CreateMap<User,UserDto>().ReverseMap();
            CreateMap<UserProfiles,UserProfilesDto>().ReverseMap();
            CreateMap<UserLogIn,RegisterDto>().ReverseMap();



        }
    }
}
