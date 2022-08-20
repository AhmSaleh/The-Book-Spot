using AutoMapper;
using TheBookSpot.DTOs.AuthorDTOs;

namespace TheBookSpot.Profiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<DTOs.AuthorDTOs.Author, TheBookSpotDomain.Entities.Author>()
                .ReverseMap();

            CreateMap<AddAuthorRequest, TheBookSpotDomain.Entities.Author>()
                .ReverseMap();

            CreateMap<AddAuthorResponse, TheBookSpotDomain.Entities.Author>()
                .ReverseMap();

            CreateMap<UpdateAuthorRequest, TheBookSpotDomain.Entities.Author>()
                .ReverseMap();

            CreateMap<UpdateAuthorResponse, TheBookSpotDomain.Entities.Author>()
               .ReverseMap();

            CreateMap<DeleteAuthorResponse, TheBookSpotDomain.Entities.Author>()
               .ReverseMap();
        }
    }
}
