using OnionArchitecture.Core.Enums;

namespace OnionArchitecture.Core.Interfaces
{
    public interface IProductServices
    {
        bool BuyProducts(ProductType productType);
    }
}