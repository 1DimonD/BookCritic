using BC.DAL.Entities;
using Bogus;
using Microsoft.EntityFrameworkCore;

namespace BC.DAL.Context
{
    internal static class ModelBuilderExtensions
    {
        public static void Configure(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<Rating>()
                .HasOne(ra => ra.Book)
                .WithMany(b => b.Ratings)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Review>()
                .HasOne(re => re.Book)
                .WithMany(b => b.Reviews)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Book>()
                .HasIndex(b => new { b.Title, b.Author })
                .IsUnique();
        }

        private static int _entitiesCount;
        public static void Seed(this ModelBuilder modelBuilder, int entitiesCount)
        {
            _entitiesCount = entitiesCount;

            var books = GenerateBooks();
            var reviews = GenerateReviews(books);
            var ratings = GenerateRatings(books);

            modelBuilder.Entity<Book>().HasData(books);
            modelBuilder.Entity<Review>().HasData(reviews);
            modelBuilder.Entity<Rating>().HasData(ratings);
        }

        private static IEnumerable<Book> GenerateBooks()
        {
            int bookId = 1;

            var previewBookFaker = new Faker<Book>()
                .RuleFor(b => b.Id, f => bookId++)
                .RuleFor(b => b.Title, f => f.Hacker.Phrase())
                .RuleFor(b => b.Cover, f => f.Image.PicsumUrl())
                .RuleFor(b => b.Content, f => f.Lorem.Text())
                .RuleFor(b => b.Author, f => f.Name.FullName())
                .RuleFor(b => b.Genre, f => f.Music.Genre());

            return previewBookFaker.Generate(_entitiesCount);
        }

        private static IEnumerable<Review> GenerateReviews(IEnumerable<Book> books)
        {
            int reviewId = 1;

            var previewReviewFaker = new Faker<Review>()
                .RuleFor(r => r.Id, f => reviewId++)
                .RuleFor(r => r.Message, f => f.Lorem.Text())
                .RuleFor(r => r.BookId, f => f.PickRandom(books).Id)
                .RuleFor(r => r.Reviewer, f => f.Internet.UserName());

            return previewReviewFaker.Generate(_entitiesCount);
        }

        private static IEnumerable<Rating> GenerateRatings(IEnumerable<Book> books)
        {
            int ratingId = 1;

            var previewRatingFaker = new Faker<Rating>()
                .RuleFor(r => r.Id, f => ratingId++)
                .RuleFor(r => r.BookId, f => f.PickRandom(books).Id)
                .RuleFor(r => r.Score, f => f.Random.Byte(min: 1, max: 5));

            return previewRatingFaker.Generate(_entitiesCount);
        }
    }
}
