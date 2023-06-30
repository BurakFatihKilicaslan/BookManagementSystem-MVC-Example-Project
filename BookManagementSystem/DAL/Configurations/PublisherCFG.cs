using BookManagementSystem.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Globalization;

namespace BookManagementSystem.DAL.Configurations
{
	public class PublisherCFG : IEntityTypeConfiguration<Publisher>
	{
		public void Configure(EntityTypeBuilder<Publisher> builder)
		{
			builder.HasKey(x => x.ID);

			builder.Property(x => x.ID)
				   .HasColumnName("PublisherID");

			builder.Property(b => b.Name)
				   .HasColumnName("PublisherName")
				   .HasColumnType("nvarchar")
				   .HasMaxLength(100);

			builder.Property(x => x.Address)
				   .HasColumnType("nvarchar")
				   .HasMaxLength(256);

			builder.Property(x => x.Phone)
				   .HasColumnType("varchar")
				   .HasMaxLength(15);

			builder.HasData(
				new Publisher { ID = 1, Address = "Penguin Classics, 80 Strand, London, WC2R 0RL, United Kingdom", Phone = "+4402031226000", Name = "Penguin Classics", FoundationDate = DateTime.ParseExact("1946-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture)},
				new Publisher { ID = 2, Address = "HarperCollins Publishers, 195 Broadway, New York, NY 10007, United States", Phone = "+12122077000", Name = "HarperCollins Publishers", FoundationDate = DateTime.ParseExact("1817-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture)},
				new Publisher { ID = 3, Address = "Bloomsbury Publishing, 50 Bedford Square, London, WC1B 3DP, United Kingdom", Phone = "+4402076315600", Name = "Bloomsbury Publishing", FoundationDate = DateTime.ParseExact("1986-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture)}
				);
		}
	}
}
