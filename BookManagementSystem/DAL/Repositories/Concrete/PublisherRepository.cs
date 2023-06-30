using BookManagementSystem.DAL.Context;
using BookManagementSystem.DAL.Repositories.Abstract;
using BookManagementSystem.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BookManagementSystem.DAL.Repositories.Concrete
{
    public class PublisherRepository : GenericRepository<Publisher>, IPublisherRepository
    {
        private readonly BookManagementDB dB;
        public PublisherRepository(BookManagementDB dB) : base(dB)
        {
            this.dB = dB;
        }

        public Publisher GetByIDIncludeBooks(int id)
        {
            return dB.Publishers.Include(p => p.Books).FirstOrDefault(P => P.ID == id);
        }
    }
}
