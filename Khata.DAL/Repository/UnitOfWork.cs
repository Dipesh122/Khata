
using Khata.DAL.Persistance;
using Khata.DAL.Repository.IRepository;
using Microsoft.EntityFrameworkCore.Storage;
using System.Collections;

namespace Khata.DAL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly AppDbContext _context;
        bool _disposed;
        Hashtable _repositories;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        
        public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            _repositories ??= new Hashtable();

            var type = typeof(TEntity).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(GenericRepository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _context);
                _repositories.Add(type, repositoryInstance);
            }
            return (IGenericRepository<TEntity>)_repositories[type];
        }

        public IDbContextTransaction BeginTransaction()
        {
            return _context.Database.BeginTransaction();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
