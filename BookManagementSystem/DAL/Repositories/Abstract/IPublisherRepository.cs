using BookManagementSystem.Entities.Concrete;

namespace BookManagementSystem.DAL.Repositories.Abstract
{
    public interface IPublisherRepository : IRepository<Publisher>
    {
        Publisher GetByIDIncludeBooks(int id);
    }
}
