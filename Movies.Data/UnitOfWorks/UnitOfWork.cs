using Microsoft.EntityFrameworkCore.Storage;
using Movies.Data.Contexts;
using Movies.Data.UnitOfWorks.Interfaces;

namespace Movies.Data.UnitOfWorks;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Sync save change method
    /// </summary>
    /// <returns></returns>
    public int SaveChanges()
    {
        return _context.SaveChanges();
    }

    /// <summary>
    /// Async save change method
    /// </summary>
    /// <returns></returns>
    public Task<int> SaveChangesAsync()
    {
        return _context.SaveChangesAsync();
    }

    /// <summary>
    /// About begin transaction method
    /// </summary>
    /// <returns></returns>
    public IDbContextTransaction BeginTransaction()
    {
        return _context.Database.BeginTransaction();
    }
}