
using Microsoft.EntityFrameworkCore.Storage;

namespace Khata.DAL.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IDbContextTransaction BeginTransaction();
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class;
        Task<int> SaveChangeAsync();
    }
}
