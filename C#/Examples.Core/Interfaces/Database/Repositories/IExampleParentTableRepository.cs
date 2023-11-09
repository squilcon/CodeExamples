using Examples.Core.Entities;

namespace Examples.Core.Interfaces.Database.Repositories
{
    public interface IExampleParentTableRepository : IRepositoryBase<ExampleParentTableDB>
    {
        IExampleParentTableRepository IncludeChild();
    }
}
