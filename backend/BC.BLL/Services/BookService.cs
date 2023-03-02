using AutoMapper;
using BC.BLL.Services.Abstract;
using BC.Common.DTO.Book;
using BC.Common.Extensions;
using BC.DAL.Context;
using BC.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BC.BLL.Services
{
    public class BookService : BaseService
    {
        public BookService(BookCriticContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<ICollection<BookItemDTO>> GetBooks(string orderingProperty = "title")
        {

            var books = await _context.Books
                .Include(b => b.Reviews).Include(b => b.Ratings).OrderBy(orderingProperty).ToListAsync();

            return _mapper.Map<ICollection<BookItemDTO>>(books);
        }

        public async Task<ICollection<BookItemDTO>> GetRecommendedBooks(string genre)
        {

            var books = await _context.Books
                .Include(b => b.Reviews).Include(b => b.Ratings).Where(b => b.Genre == genre).ToListAsync();

            return _mapper.Map<ICollection<BookItemDTO>>(books).Where(bi => bi.ReviewsNumber > 10).Take(10).ToList();
        }

        public async Task<int> SaveBook(NewBookDTO newBookDTO)
        {
            var book = _mapper.Map<Book>(newBookDTO);

            var updateBook = await _context.Books.Where(b => b.Id == book.Id).FirstOrDefaultAsync();
            if (updateBook != null) 
            { 
                _mapper.Map(book, updateBook);
            }
            else
            {
                book.Id = await _context.Books.MaxAsync(x => x.Id) + 1;
                _context.Add(book);
            }
            _context.SaveChanges();

            return book.Id;
        }

    }
}
