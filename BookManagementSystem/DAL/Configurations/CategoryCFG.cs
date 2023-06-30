using BookManagementSystem.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookManagementSystem.DAL.Configurations
{
	public class CategoryCFG : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.HasKey(x => x.ID);

			builder.Property(x => x.ID)
				   .HasColumnName("CategoryID");

			builder.Property(b => b.Name)
				   .HasColumnName("CategoryName")
				   .HasColumnType("nvarchar")
				   .HasMaxLength(100);

			builder.Property(x => x.Description)
				   .HasColumnType("nvarchar")
				   .HasMaxLength(1000);

			builder.HasData(
				new Category { ID = 1, Name = "Novel", Description = "Fictional prose narrative of considerable length, typically representing characters and actions in a realistic way." },
				new Category { ID = 2, Name = "Science Fiction", Description = "Genre of speculative fiction that typically deals with imaginative and futuristic concepts, often incorporating advanced science and technology." },
				new Category { ID = 3, Name = "Mystery and Thriller", Description = "Genre of fiction that involves solving a mysterious event or crime and usually creates a sense of suspense and excitement." },
				new Category { ID = 4, Name = "Historical Fiction", Description = "Genre of fiction that takes place in the past and often incorporates real historical events, figures, or settings while incorporating fictional elements." },
				new Category { ID = 5, Name = "Biography", Description = "Account of a person's life written by someone else, providing a detailed description of the person's experiences, achievements, and challenges." }
				);
		}
	}
}
