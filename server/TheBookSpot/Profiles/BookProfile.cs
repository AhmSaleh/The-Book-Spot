using AutoMapper;
using TheBookSpot.DTOs.AuthorDTOs;
using TheBookSpot.DTOs.BookDTOs;

namespace TheBookSpot.Profiles
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<DTOs.BookDTOs.Book, TheBookSpotDomain.Entities.Book>()
                .ReverseMap();

            CreateMap<AddBookRequest, TheBookSpotDomain.Entities.Book>()
                .ReverseMap();

            CreateMap<AddBookResponse, TheBookSpotDomain.Entities.Book>()
                .ReverseMap();

            CreateMap<UpdateBookRequest, TheBookSpotDomain.Entities.Book>()
                .ReverseMap();

            CreateMap<UpdateBookResponse, TheBookSpotDomain.Entities.Book>()
                .ReverseMap();

            CreateMap<DeleteBookResponse, TheBookSpotDomain.Entities.Book>()
             .ReverseMap();
        }
    }
}
