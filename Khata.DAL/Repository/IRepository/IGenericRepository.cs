
namespace Khata.DAL.Repository.IRepository
{
    public interface IGenericRepository<TEntity>
    {
        Task<TEntity> AddAsync(TEntity entity);
        TEntity UpdateAsync(TEntity entity);
        Task<TEntity> DeleteAsync(Guid id);
        Task<TEntity> GetByIdAsync(Guid id);
        Task<List<TEntity>> GetAllAsync();
        Task<int> SaveChangeAsync();
    }
}
