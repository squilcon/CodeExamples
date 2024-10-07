using Examples.Core.Interfaces.Database.Repositories;

namespace Examples.Core.Interfaces.Database
{
    public interface IUnitOfWork
    {
        Task<int> CommitAsync();
        IExampleChildTableRepository ExampleChildTables();
        IExampleParentTableRepository ExampleParentTables();
    }
}