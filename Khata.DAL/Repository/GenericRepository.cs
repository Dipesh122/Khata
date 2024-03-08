
using Khata.DAL.Persistance;
using Khata.DAL.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Khata.DAL.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        readonly AppDbContext _context;
        readonly DbSet<TEntity> _dbSet;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }

        public async Task<TEntity> DeleteAsync(Guid id)
        {
            var entity = await _dbSet.FindAsync(id);
            _dbSet.Remove(entity);
            return entity;
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public TEntity UpdateAsync(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return entity;
        }
    }
}
