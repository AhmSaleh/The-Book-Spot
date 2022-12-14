using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TheBookSpot.DTOs.AuthorDTOs;
using TheBookSpotData.Services.AuthorSevices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheBookSpot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService service;
        private readonly IMapper mapper;

        public AuthorController(IAuthorService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        [HttpGet("{pageIndex:int}, {pageSize:int}")]
        public async Task<IActionResult> GetAllAuthorsAsync(int pageIndex, int pageSize)
        {
            var authors = await service.GetAllAsync(pageIndex, pageSize, a => a.Books);

            var authorsDTO = mapper.Map<IEnumerable<DTOs.AuthorDTOs.Author>>(authors);

            return Ok(authorsDTO);
        }

        [HttpGet("{id:Guid}")]
        [ActionName(nameof(GetAuthorAsync))]
        public async Task<IActionResult> GetAuthorAsync(Guid id)
        {
            var author = await service.GetAsync(id, a => a.Books);

            if (author == null)
                return NotFound();

            var authorDTO = mapper.Map<DTOs.AuthorDTOs.Author>(author);

            return Ok(authorDTO);
        }

        [HttpPost]
        public async Task<IActionResult> AddAuthorAsync(AddAuthorRequest addAuthorRequest)
        {
            var author = mapper.Map<TheBookSpotDomain.Entities.Author>(addAuthorRequest);
            author = await service.AddAsync(author);

            var addedAuthorDTO = mapper.Map<AddAuthorResponse>(author);

            return CreatedAtAction(nameof(GetAuthorAsync), new { id = addedAuthorDTO.Id }, addedAuthorDTO);
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> UpdateAuthorAsync(Guid id, UpdateAuthorRequest updateAuthorRequest)
        {
            var author = mapper.Map<TheBookSpotDomain.Entities.Author>(updateAuthorRequest);

            author = await service.UpdateAsync(id, author);

            if (author == null)
                return NotFound();

            var updatedAuthorDTO = mapper.Map<UpdateAuthorResponse>(author);

            return Ok(updatedAuthorDTO);
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> DeleteAuthorAsync(Guid id)
        {

            var author = await service.DeleteAsync(id);

            if (author == null)
                return NotFound();

            var authorDTO = mapper.Map<DeleteAuthorResponse>(author);

            return Ok(authorDTO);
        }
    }
}
