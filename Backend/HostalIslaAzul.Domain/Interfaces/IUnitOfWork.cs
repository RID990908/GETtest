using HostalIslaAzul.Domain.Entities;

namespace HostalIslaAzul.Domain.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;
    Task<int> SaveChangesAsync();
}