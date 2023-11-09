using Examples.Core.Interfaces.Database.Repositories;
using Examples.Core.Entities;
using Examples.Database.Context;
using Microsoft.EntityFrameworkCore;

namespace Examples.Database.Repositories
{
    public class ExampleParentTableRepository : RepositoryBase<ExampleParentTableDB>, IExampleParentTableRepository
    {
        public ExampleParentTableRepository(ExamplesContext context)
            : base(context) { }

        public IExampleParentTableRepository IncludeChild()
        {
            Query = Query.Include(x => x.Children);
            return this;
        }
    }
}
