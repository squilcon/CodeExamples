using OnionArchitecture.Core.Model;

namespace OnionArchitecture.Core.Interfaces
{
    public interface IProductRepository
    {
        bool SaveProduct(Product product);
    }
}