using Examples.Core.Interfaces.Database;
using Examples.Core.Interfaces.Database.Repositories;
using Examples.Database.Context;
using Examples.Database.Repositories;

namespace Examples.Database
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ExamplesContext _context;
        private IExampleParentTableRepository? _exampleParentTableRepository;
        private IExampleChildTableRepository? _exampleChildTableRepository;

        public UnitOfWork(ExamplesContext context)
        {
            _context = context;
        }

        public IExampleParentTableRepository ExampleParentTables()
        {
            return _exampleParentTableRepository ??= new ExampleParentTableRepository(_context);
        }

        public IExampleChildTableRepository ExampleChildTables()
        {
            return _exampleChildTableRepository ??= new ExampleChildTableRepository(_context);
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
