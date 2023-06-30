using BookManagementSystem.DAL.Context;
using BookManagementSystem.DAL.Repositories.Abstract;
using BookManagementSystem.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BookManagementSystem.DAL.Repositories.Concrete
{
	public class BookRepository : GenericRepository<Book>, IBookRepository
	{
		private readonly BookManagementDB db;

		public BookRepository(BookManagementDB db) : base(db) 
		{
			this.db = db;
		}

        public IEnumerable<Book> GetByIDIncludeCategoryIncludeAuthorIncludePublisherAll()
		{
			return db.Books.Include(b => b.Category).Include(b => b.Author).Include(b => b.Publisher);
		}

		public Book GetByIDIncludeCategoryIncludeAuthorIncludePublisherFirstOrDefault(int id)
		{
			return db.Books.Include(b => b.Category).Include(b => b.Author).Include(b => b.Publisher).FirstOrDefault(b => b.ID == id);
		}
    }
}
