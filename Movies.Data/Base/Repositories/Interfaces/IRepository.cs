using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Movies.Core.Repositories.Interfaces;

public interface IRepository<TEntity> where TEntity : class
{
    public IQueryable<TEntity> Query();
    public ValueTask<EntityEntry<TEntity>> AddAsync(TEntity entity);
    public EntityEntry<TEntity> Add(TEntity entity);
    public Task AddRangeAsync(ICollection<TEntity> entities);
    public EntityEntry<TEntity> Update(TEntity entity);
    public void UpdateRange(ICollection<TEntity> entities);
    public void Remove(TEntity entity);
    public void RemoveRange(ICollection<TEntity> entities);
    Task<TEntity?> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
    TEntity? SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
    Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> predicate);
    Task<TEntity?> FindAsync(Expression<Func<TEntity, bool>> expression);
    TEntity? Find(Expression<Func<TEntity, bool>> expression);
    Task<TEntity?> FindAsNoTrackingAsync(Expression<Func<TEntity, bool>> expression);
    Task<List<TEntity>> FindListAsync(Expression<Func<TEntity, bool>> expression = null);
    Task<List<TEntity>> FindListAsNoTrackingAsync(Expression<Func<TEntity, bool>> expression = null);
    Task<bool> Any(Expression<Func<TEntity, bool>> expression);
}