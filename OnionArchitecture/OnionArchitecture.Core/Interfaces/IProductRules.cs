using OnionArchitecture.Core.Enums;

namespace OnionArchitecture.Core.Interfaces
{
    public interface IProductRules
    {
        decimal GetProductPrice(ProductType productType);
    }
}