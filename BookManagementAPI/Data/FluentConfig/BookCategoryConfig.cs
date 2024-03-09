using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookManagementAPI.Data.FluentConfig
{
    public class BookCategoryConfig : IEntityTypeConfiguration<BookCategoryMap>
    {
        public void Configure(EntityTypeBuilder<BookCategoryMap> builder)
        {
            builder.HasKey(bc => new { bc.BookId, bc.CategoryId });
            builder.HasOne(bc => bc.Book).WithMany(bc => bc.BookCategoryMap).HasForeignKey(bc => bc.BookId);
            builder.HasOne(bc => bc.Category).WithMany(bc => bc.BookCategoryMap).HasForeignKey(bc => bc.CategoryId);
        }
    }
}
