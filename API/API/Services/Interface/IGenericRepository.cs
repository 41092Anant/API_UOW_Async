using System.Linq.Expressions;

namespace API.Services.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        Task Add(T entity);
        Task<IEnumerable<T>> GetAll();
        Task Update(T entity);
        Task Remove(T entity);
        Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate);
        Task<int> CountAll();
    }
}
