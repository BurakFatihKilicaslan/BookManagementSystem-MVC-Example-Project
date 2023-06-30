using System.Linq.Expressions;

namespace BookManagementSystem.DAL.Repositories.Abstract
{
    public interface IRepository<T>
    {
        bool Add(T entity);
        bool Delete(T entity);
        bool Update(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();

        //LINQ
        T GetFirstOrDefault(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetWhere(Expression<Func<T, bool>> predicate);
    }
}
