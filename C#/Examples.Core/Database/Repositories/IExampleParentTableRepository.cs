using Examples.Core.Database.Entities;

namespace Examples.Core.Database.Repositories
{
    public interface IExampleParentTableRepository : IRepositoryBase<ExampleParentTableDB>
    {
        IExampleParentTableRepository IncludeChild();
    }
}
