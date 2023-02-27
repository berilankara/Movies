using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Movies.Core.Repositories.Interfaces;
using Movies.Data.Contexts;

namespace Movies.Data.Repositories.Base;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly DbContext _context;
    protected readonly DbSet<TEntity> _dbSet;

    public Repository(AppDbContext context)
    {
        _context = context;
        _dbSet = context.Set<TEntity>();
    }

    public IQueryable<TEntity> Query()
    {
        return _dbSet.AsQueryable();
    }

    public IQueryable<TEntity> ReadQuery()
    {
        return _dbSet
            .AsQueryable()
            .AsNoTracking();
    }

    public IQueryable<TEntity> GetAll()
    {
        return _dbSet.AsQueryable();
    }

    public ValueTask<EntityEntry<TEntity>> AddAsync(TEntity entity)
    {
        return _dbSet.AddAsync(entity);
    }

    public EntityEntry<TEntity> Add(TEntity entity)
    {
        return _dbSet.Add(entity);
    }

    public Task AddRangeAsync(ICollection<TEntity> entities)
    {
        return _dbSet.AddRangeAsync(entities);
    }

    public EntityEntry<TEntity> Update(TEntity entity)
    {
        if (_dbSet.Local.Any(x => x == entity))
        {
            return null;
        }

        return _dbSet.Update(entity);
    }

    public void UpdateRange(ICollection<TEntity> entities)
    {
        foreach (var entity in entities)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }

    public void Remove(TEntity entity)
    {
        _dbSet.Remove(entity);
    }

    public void RemoveRange(ICollection<TEntity> entities)
    {
        _dbSet.RemoveRange(entities);
    }

    public async Task<TEntity?> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return await _dbSet.SingleOrDefaultAsync(predicate);
    }

    public TEntity? SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
    {
        return _dbSet.SingleOrDefault(predicate);
    }

    public async Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> predicate)
    {
        return await _dbSet.Where(predicate).ToListAsync();
    }

    public async Task<TEntity?> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public TEntity? GetById(int id)
    {
        return _dbSet.Find(id);
    }

    public async Task<TEntity?> FindAsync(Expression<Func<TEntity, bool>> expression)
    {
        return await _dbSet.Where(expression).SingleOrDefaultAsync();
    }

    public TEntity? Find(Expression<Func<TEntity, bool>> expression)
    {
        return _dbSet.Where(expression).FirstOrDefault();
    }

    public async Task<TEntity?> FindAsNoTrackingAsync(Expression<Func<TEntity, bool>> expression)
    {
        return await _dbSet
            .Where(expression)
            .AsNoTracking()
            .SingleOrDefaultAsync();
    }

    public async Task<List<TEntity>> FindListAsync(Expression<Func<TEntity, bool>> expression = null)
    {
        return await _dbSet
            .Where(expression)
            .ToListAsync();
    }

    public async Task<List<TEntity>> FindListAsNoTrackingAsync(Expression<Func<TEntity, bool>> expression = null)
    {
        return await _dbSet
            .Where(expression)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<bool> Any(Expression<Func<TEntity, bool>> expression)
    {
        return await _dbSet
            .AnyAsync(expression);
    }
}