using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TheBookSpot.DTOs.AuthorDTOs;
using TheBookSpot.DTOs.BookDTOs;
using TheBookSpotData.Services.BookServices;

namespace TheBookSpot.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : Controller
    {
        private readonly IBookService service;
        private readonly IMapper mapper;

        public BookController(IBookService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBooksAsync()
        {
            var books = await service.GetAllAsync();
            var booksDTO = mapper.Map<IEnumerable<Book>>(books);

            return Ok(booksDTO);
        }

        [HttpGet("{id:Guid}")]
        [ActionName(nameof(GetBookAsync))]
        public async Task<IActionResult> GetBookAsync(Guid id)
        {
            var book = await service.GetAsync(id);

            if (book == null)
                return NotFound();

            var bookDTO = mapper.Map<Book>(book);

            return Ok(bookDTO);
        }

        [HttpPost]
        public async Task<IActionResult> AddBookAsync(AddBookRequest addBookRequest)
        {
            var book = mapper.Map<TheBookSpotDomain.Book>(addBookRequest);

            book = await service.AddAsync(book);

            var addedBookDTO = mapper.Map<AddBookResponse>(book);

            return CreatedAtAction(nameof(GetBookAsync), new { id = addedBookDTO.Id }, addedBookDTO);
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> UpdateBookAsync(Guid id, UpdateBookRequest updateBookRequest)
        {
            var book = mapper.Map<TheBookSpotDomain.Book>(updateBookRequest);

            book = await service.UpdateAsync(id, book);

            var updatedBookDTO = mapper.Map<UpdateBookResponse>(book);

            return Ok(updatedBookDTO);
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> DeleteBookAsync(Guid id)
        {
            var book = await service.DeleteAsync(id);

            if (book == null)
                return NotFound();

            var bookDTO = mapper.Map<DeleteBookResponse>(book);

            return Ok(bookDTO);
        }
    }
}
