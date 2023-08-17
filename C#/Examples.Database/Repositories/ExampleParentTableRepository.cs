using Examples.Core.Database.Entities;
using Examples.Core.Database.Repositories;
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
