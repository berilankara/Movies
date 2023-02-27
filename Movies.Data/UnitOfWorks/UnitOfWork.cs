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

    // Sync save change method
    public int SaveChanges()
    {
        return _context.SaveChanges();
    }

    // Async save change method
    public Task<int> SaveChangesAsync()
    {
        return _context.SaveChangesAsync();
    }

    // About begin transaction method
    public IDbContextTransaction BeginTransaction()
    {
        return _context.Database.BeginTransaction();
    }
}