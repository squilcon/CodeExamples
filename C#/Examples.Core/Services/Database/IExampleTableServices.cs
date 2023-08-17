namespace Examples.Core.Services.Database
{
    public interface IExampleTableServices
    {
        Task<int> AddExampleTableAsync(string name);
        Task<string> GetExampleTableByIDAsync(int id);
    }
}