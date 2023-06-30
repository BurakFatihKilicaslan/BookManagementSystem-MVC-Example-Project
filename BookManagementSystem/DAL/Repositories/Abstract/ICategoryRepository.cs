using BookManagementSystem.Entities.Concrete;

namespace BookManagementSystem.DAL.Repositories.Abstract
{
	public interface ICategoryRepository : IRepository<Category>
	{
		Category GetByIDIncludeBooks(int id);
	}
}
