using OnionArchitecture.Core.Interfaces;
using OnionArchitecture.Core.Model;

namespace OnionArchitecture.Database
{
    internal class ProductRepository : IProductRepository
    {
        public bool SaveProduct(Product product)
        {
            return true;
        }
    }
}
