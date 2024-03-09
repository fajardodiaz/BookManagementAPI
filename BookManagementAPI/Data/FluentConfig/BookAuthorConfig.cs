using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookManagementAPI.Data.FluentConfig
{
    public class BookAuthorConfig : IEntityTypeConfiguration<BookAuthorMap>
    {
        public void Configure(EntityTypeBuilder<BookAuthorMap> builder)
        {
            builder.HasKey(k => new { k.BookId, k.AuthorId });
            builder.HasOne(a => a.Author).WithMany(a => a.BookAuthorMap).HasForeignKey(a => a.BookId);
            builder.HasOne(b => b.Book).WithMany(b => b.BookAuthorMap).HasForeignKey(b => b.AuthorId);
        }
    }
}
