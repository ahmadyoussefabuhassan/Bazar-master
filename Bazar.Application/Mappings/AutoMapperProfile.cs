using AutoMapper;
using Bazar.Application.DTOs;
using Bazar.Domain.Entitis;
namespace Bazar.Application.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Defines a two-way map between Electronics entity and its DTO.
            // ReverseMap() allows mapping in both directions (Entity ↔️ DTO).
            // This works well if their properties mostly match
            CreateMap<Electronics,ElectronicsDto>().ReverseMap();
            // Same as above, mapping between Books entity and DTO
            CreateMap<Books,BooksDto>().ReverseMap();
            // Two-way mapping between Animals entity and DTO
            CreateMap<Animals,AnimalsDto>().ReverseMap();
            // Maps Sports entity to DTO and back
            CreateMap<Sports, SportsDto>().ReverseMap();
            // Maps Furniture entity and DTO
            CreateMap<Furniture,FurnitureDto>().ReverseMap();
            // For mapping between Kitchen entity and DTO.
            CreateMap<Kitchen,KitchenDto>().ReverseMap();
            // Maps Advertisement entities and DTOs.
            CreateMap<Advertisements,AdvertisementsDto>().ReverseMap();
            // Maps Category entity and DTO.
            CreateMap<Category,CategoryDto>().ReverseMap();
            // Maps User entity and its DTO.
            CreateMap<User,UserDto>().ReverseMap();
            // Handles complex mapping between UserProfiles entity and DTO.
            // Useful especially if it has nested or detailed properties.
            CreateMap<UserProfiles,UserProfilesDto>().ReverseMap();
            // Maps between UserLogIn entity and RegisterDto.
            // Explicitly maps Email property since it exists on both.
            // Ignores UserProfiles on the reverse map because RegisterDto doesn't have it,
            // and you typically don’t map this during registration.
            CreateMap<UserLogIn, RegisterDto>()
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ReverseMap()
                .ForMember(dest => dest.UserProfiles , opt => opt.Ignore());
            // Maps Images entity and DTO bidirectionally,
            // good for transferring image-related data.
            CreateMap<Images,ImagesDto>().ReverseMap();
        }
    }
}
