using Microsoft.EntityFrameworkCore.Storage;

namespace Movies.Data.UnitOfWorks.Interfaces;

public interface IUnitOfWork
{
    /// <summary>
    /// Sync save change method
    /// </summary>
    /// <returns></returns>
    int SaveChanges(); 
    
    /// <summary>
    /// Async save change method
    /// </summary>
    /// <returns></returns>
    Task<int> SaveChangesAsync();
    
    /// <summary>
    /// About begin transaction method
    /// </summary>
    /// <returns></returns>
    IDbContextTransaction BeginTransaction();
}