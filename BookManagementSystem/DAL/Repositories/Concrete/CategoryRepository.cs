using BookManagementSystem.DAL.Context;
using BookManagementSystem.DAL.Repositories.Abstract;
using BookManagementSystem.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BookManagementSystem.DAL.Repositories.Concrete
{
	public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
	{
		private readonly BookManagementDB db;
		public CategoryRepository(BookManagementDB db) : base(db)
		{
			this.db = db;
		}

		public Category GetByIDIncludeBooks(int id)
		{
			return db.Categories.Include(c=>c.Books).FirstOrDefault(c=>c.ID==id);
		}
	}
}
