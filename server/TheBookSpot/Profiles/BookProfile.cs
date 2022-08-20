using AutoMapper;
using TheBookSpot.DTOs.AuthorDTOs;
using TheBookSpot.DTOs.BookDTOs;

namespace TheBookSpot.Profiles
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<Book, TheBookSpotDomain.Book>()
                .ReverseMap();

            CreateMap<AddBookRequest, TheBookSpotDomain.Book>()
                .ReverseMap();

            CreateMap<AddBookResponse, TheBookSpotDomain.Book>()
                .ReverseMap();

            CreateMap<UpdateBookRequest, TheBookSpotDomain.Book>()
                .ReverseMap();

            CreateMap<UpdateBookResponse, TheBookSpotDomain.Book>()
                .ReverseMap();

            CreateMap<DeleteBookResponse, TheBookSpotDomain.Book>()
             .ReverseMap();
        }
    }
}
