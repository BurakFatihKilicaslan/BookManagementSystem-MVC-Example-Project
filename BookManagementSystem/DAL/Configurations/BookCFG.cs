using BookManagementSystem.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Globalization;

namespace BookManagementSystem.DAL.Configurations
{
	public class BookCFG : IEntityTypeConfiguration<Book>
	{
		public void Configure(EntityTypeBuilder<Book> builder)
		{
			builder.HasKey(x => x.ID);

			builder.Property(x => x.ID)
				   .HasColumnName("BookID");

			builder.Property(b => b.Name)
				   .HasColumnName("BookName")
				   .HasColumnType("nvarchar")
				   .HasMaxLength(100);

			builder.Property(b => b.PageCount)
				   .HasColumnType("int");

			builder.HasOne(b => b.Publisher)
				   .WithMany(b => b.Books)
				   .HasForeignKey(b => b.PublisherID)
				   .OnDelete(DeleteBehavior.SetNull);

			builder.HasOne(b => b.Author)
				   .WithMany(b => b.Books)
				   .HasForeignKey(b => b.AuthorID)
				   .OnDelete(DeleteBehavior.SetNull);

			builder.HasOne(b => b.Category)
				   .WithMany(b => b.Books)
				   .HasForeignKey(b => b.CategoryID)
				   .OnDelete(DeleteBehavior.SetNull);

			builder.HasData(
				new Book { ID = 1, PageCount = 320, Name = "Hamlet", AuthorID = 2 , PublisherID = 1, CategoryID = 1, PublicationDate = DateTime.ParseExact("1603-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture)},
				new Book { ID = 2, PageCount = 432, Name = "Pride and Prejudice", AuthorID = 3 , PublisherID = 1, CategoryID = 1, PublicationDate = DateTime.ParseExact("1813-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture)},
				new Book { ID = 3, PageCount = 1178, Name = "The Lord of the Rings", AuthorID = 4, PublisherID = 2, CategoryID = 2, PublicationDate = DateTime.ParseExact("1954-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture)},
				new Book { ID = 4, PageCount = 256, Name = "Murder on the Orient Express", AuthorID = 5, PublisherID = 2, CategoryID = 3, PublicationDate = DateTime.ParseExact("1934-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture)},
				new Book { ID = 5, PageCount = 223, Name = "Harry Potter and the Philosopher's Stone", AuthorID = 1, PublisherID = 3, CategoryID = 2, PublicationDate = DateTime.ParseExact("1997-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture)},
				new Book { ID = 6, PageCount = 464, Name = "The Grapes of Wrath", AuthorID = 6, PublisherID = 1, CategoryID = 1, PublicationDate = DateTime.ParseExact("1939-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture)}
			);
		}
	}
}
