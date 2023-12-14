using Microsoft.EntityFrameworkCore;
using MLS.Application.Contracts.Persistence.Common;
using MLS.Domain.Common;
using MLS.Persistence.DatabaseContext;

namespace MLS.Persistence.Repository.Common
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly MatLidStoreDatabaseContext _context;

        public GenericRepository(MatLidStoreDatabaseContext context)
        {
            _context = context;
        }

        public async Task Create(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAll()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}