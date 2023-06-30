using BookManagementSystem.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Globalization;

namespace BookManagementSystem.DAL.Configurations
{
    public class AuthorCFG : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID)
                   .HasColumnName("AuthorID");

            builder.Property(b => b.Name)
                   .HasColumnName("AuthorName")
                   .HasColumnType("nvarchar")
                   .HasMaxLength(100);
            
            builder.HasData(
                    new Author
                    {
                        ID = 1,
                        BirthDate = DateTime.ParseExact("1965-03-03", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DeathDate = null,
                        Name = "J.K.Rowling"
                    },
                    new Author
                    {
                        ID = 2,
                        BirthDate = DateTime.ParseExact("1564-04-26", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DeathDate = DateTime.ParseExact("1616-04-23", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Name = "William Shakespeare"
                    },
                    new Author
                    {
                        ID = 3,
                        BirthDate = DateTime.ParseExact("1775-11-16", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DeathDate = DateTime.ParseExact("1817-08-18", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Name = "Jane Austen"
                    },
                    new Author
                    {
                        ID = 4,
                        BirthDate = DateTime.ParseExact("1892-01-03", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DeathDate = DateTime.ParseExact("1973-09-02", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Name = "J.R.R. Tolkien"
                    },
                    new Author
                    {
                        ID = 5,
                        BirthDate = DateTime.ParseExact("1890-09-15", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DeathDate = DateTime.ParseExact("1976-01-12", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Name = "Agatha Christie"
                    },
                    new Author
                    {
                        ID = 6,
                        BirthDate = DateTime.ParseExact("1902-02-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DeathDate = DateTime.ParseExact("1968-12-20", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Name = "John Steinbeck"
                    }
                );

        }
    }
}
