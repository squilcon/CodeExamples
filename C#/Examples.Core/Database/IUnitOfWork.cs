using Examples.Core.Database.Repositories;

namespace Examples.Core.Database
{
    public interface IUnitOfWork
    {
        Task<int> CommitAsync();
        IExampleChildTableRepository ExampleChildTables();
        IExampleParentTableRepository ExampleParentTables();
    }
}