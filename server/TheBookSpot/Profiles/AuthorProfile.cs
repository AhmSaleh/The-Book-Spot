using AutoMapper;
using TheBookSpot.DTOs.AuthorDTOs;

namespace TheBookSpot.Profiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, TheBookSpotDomain.Author>()
                .ReverseMap();

            CreateMap<AddAuthorRequest, TheBookSpotDomain.Author>()
                .ReverseMap();

            CreateMap<AddAuthorResponse, TheBookSpotDomain.Author>()
                .ReverseMap();

            CreateMap<UpdateAuthorRequest, TheBookSpotDomain.Author>()
                .ReverseMap();

            CreateMap<UpdateAuthorResponse, TheBookSpotDomain.Author>()
               .ReverseMap();

            CreateMap<DeleteAuthorResponse, TheBookSpotDomain.Author>()
               .ReverseMap();
        }
    }
}
