using BookManagementSystem.DAL.Configurations;
using BookManagementSystem.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BookManagementSystem.DAL.Context
{
	public class BookManagementDB : DbContext
	{
		public BookManagementDB(DbContextOptions options) : base(options)
		{

		}
		public DbSet<Book> Books { get; set; }
		public DbSet<Author> Authors { get; set; }
		public DbSet<Publisher> Publishers { get; set; }
		public DbSet<Category> Categories { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new BookCFG());
			modelBuilder.ApplyConfiguration(new AuthorCFG());
			modelBuilder.ApplyConfiguration(new PublisherCFG());
			modelBuilder.ApplyConfiguration(new CategoryCFG());
		}
	}
}
