using BookManagementSystem.Entities.Concrete;

namespace BookManagementSystem.DAL.Repositories.Abstract
{
	public interface IAuthorRepository : IRepository<Author>
	{
		Author GetByIDIncludeBooks(int id);
	}
}
