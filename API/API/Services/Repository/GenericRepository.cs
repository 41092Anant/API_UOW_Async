using API.Data;
using API.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace API.Services.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly PeopleContext _context;
        public GenericRepository(PeopleContext context)
        {
            _context = context;
        }

        public async Task Add(T entity)
        {
            // await Context.AddAsync(entity);
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public Task Update(T entity)
        {
            // In case AsNoTracking is used
            _context.Entry(entity).State = EntityState.Modified;
            return _context.SaveChangesAsync();
        }

        public Task Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
            return _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().Where(predicate).ToListAsync();
        }

        public Task<int> CountAll() => _context.Set<T>().CountAsync();

    }
}
