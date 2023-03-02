using BC.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.DAL.Context
{
    public class BookCriticContext : DbContext
    {
        public DbSet<Book> Books { get; private set; }
        public DbSet<Rating> Ratings { get; private set; }
        public DbSet<Review> Reviews { get; private set; }


        public BookCriticContext(DbContextOptions<BookCriticContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase(databaseName: "BookCritic");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Configure();
              
            modelBuilder.Seed(100);
        }
    }
}
