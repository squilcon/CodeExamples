using Examples.Core.Database;
using Examples.Core.Database.Entities;
using Examples.Core.Services.Database;

namespace Examples.Services.Database
{
    public class ExampleTableServices : IExampleTableServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExampleTableServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> AddExampleTableAsync(string name)
        {
            var exampleTable = new ExampleParentTableDB()
            {
                Name = name
            };

            await _unitOfWork.ExampleParentTables().AddAsync(exampleTable);
            await _unitOfWork.CommitAsync();

            return exampleTable.ID;
        }

        public async Task<string> GetExampleTableByIDAsync(int id)
        {
            var exampleTable = await _unitOfWork.ExampleParentTables().IncludeChild()
                                                                      .SingleOrDefaultAsync(x => x.ID.Equals(id));
            return exampleTable is null ? string.Empty : exampleTable.Name;
        }
    }
}
