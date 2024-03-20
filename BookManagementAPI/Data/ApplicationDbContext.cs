using BookManagementAPI.Data.FluentConfig;
using Microsoft.EntityFrameworkCore;

namespace BookManagementAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        //Models
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        
        //Relation Tables
        public DbSet<BookAuthorMap> BookAuthorMap { get; set; }
        public DbSet<BookCategoryMap> BookCategoriesMap { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Models
            modelBuilder.ApplyConfiguration(new AuthorConfig());
            modelBuilder.ApplyConfiguration(new BookConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new PublisherConfig());
            // Relation Tables
            modelBuilder.ApplyConfiguration(new BookAuthorConfig());
            modelBuilder.ApplyConfiguration(new BookCategoryConfig());
        }
    }
}
