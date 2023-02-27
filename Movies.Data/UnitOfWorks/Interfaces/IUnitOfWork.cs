using Microsoft.EntityFrameworkCore.Storage;

namespace Movies.Data.UnitOfWorks.Interfaces;

public interface IUnitOfWork
{
    // Sync save change method
    int SaveChanges(); 
    
    // Async save change method
    Task<int> SaveChangesAsync();
    
    // About begin transaction method
    IDbContextTransaction BeginTransaction();
}