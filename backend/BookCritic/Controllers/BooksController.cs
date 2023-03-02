using BC.BLL.Services;
using BC.Common.DTO.Book;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace BookCritic.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private readonly BookService _bookService;
        private readonly IValidator<NewBookDTO> _validator;

        public BooksController(BookService bookService, IValidator<NewBookDTO> validator)
        {
            _bookService = bookService;
            _validator = validator;
        }

        [HttpGet()]
        public async Task<ActionResult<ICollection<BookItemDTO>>> GetBooks(string order)
        {
            return Ok(await _bookService.GetBooks(order));
        }

        [HttpGet("/api/recommended")]
        public async Task<ActionResult<ICollection<BookItemDTO>>> GetRecommendedBooks(string genre)
        {
            return Ok(await _bookService.GetRecommendedBooks(genre));
        }

        [HttpPost("save")]
        public async Task<ActionResult<int>> SaveBook([FromBody] NewBookDTO newBookDTO)
        {
            if(!_validator.Validate(newBookDTO).IsValid)
            {
                return BadRequest(newBookDTO);
            }
            return Ok(await _bookService.SaveBook(newBookDTO));
        }

    }
}
