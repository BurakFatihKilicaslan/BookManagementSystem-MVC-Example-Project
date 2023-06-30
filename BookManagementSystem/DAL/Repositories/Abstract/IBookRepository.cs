using BookManagementSystem.Entities.Concrete;

namespace BookManagementSystem.DAL.Repositories.Abstract
{
	public interface IBookRepository : IRepository<Book>
	{
		IEnumerable<Book> GetByIDIncludeCategoryIncludeAuthorIncludePublisherAll();
		Book GetByIDIncludeCategoryIncludeAuthorIncludePublisherFirstOrDefault(int id);
	}
}
