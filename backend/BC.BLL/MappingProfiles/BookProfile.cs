using AutoMapper;
using BC.Common.DTO.Book;
using BC.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.BLL.MappingProfiles
{
    public sealed class BookProfile : Profile
    {
        public BookProfile() {
            CreateMap<Book, BookItemDTO>()
                .ForMember(bi => bi.Rating, o => o.MapFrom(b => (decimal)Math.Round(b.Ratings.DefaultIfEmpty().Average(r => r!.Score), 2)))
                .ForMember(bi => bi.ReviewsNumber, o => o.MapFrom(b => b.Reviews.Count()));
            CreateMap<BookItemDTO, Book>();
        }
    }
}
