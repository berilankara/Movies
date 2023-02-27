using Movies.Core.UnitOfWorks.Interfaces;

namespace Movies.Core.UnitOfWorks;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    private readonly IServiceProvider _services;

    public UnitOfWork(AppDbContext context, IServiceProvider services)
    {
        _context = context;
        _services = services;
    }

    public int SaveChanges()
    {
        return _context.SaveChanges();
    }

    public Task<int> SaveChangesAsync()
    {
        return _context.SaveChangesAsync();
    }
}