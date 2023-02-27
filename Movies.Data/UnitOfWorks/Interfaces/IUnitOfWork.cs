namespace Movies.Core.UnitOfWorks.Interfaces;

public interface IUnitOfWork
{
    int SaveChanges(); 
    Task<int> SaveChangesAsync();
}