using BookManagementSystem.DAL.Context;
using BookManagementSystem.DAL.Repositories.Abstract;
using BookManagementSystem.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BookManagementSystem.DAL.Repositories.Concrete
{
	public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
	{
		private readonly BookManagementDB db;
		public AuthorRepository(BookManagementDB db) : base(db)
		{
			this.db = db;
		}
		public Author GetByIDIncludeBooks(int id)
		{
			return db.Authors.Include(a=>a.Books).FirstOrDefault(a=>a.ID == id);
		}
	}
}
