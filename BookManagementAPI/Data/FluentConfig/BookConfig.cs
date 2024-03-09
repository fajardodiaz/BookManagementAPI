using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookManagementAPI.Data.FluentConfig
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasIndex(b => b.ISBN).IsUnique();
            builder.Property(b => b.ISBN).IsRequired().HasMaxLength(50);
            builder.Property(b => b.Title).IsRequired().HasMaxLength(125);
            builder.HasOne(b => b.Publisher).WithMany(b => b.Books).HasForeignKey(b => b.PublisherId);
        }
    }
}
