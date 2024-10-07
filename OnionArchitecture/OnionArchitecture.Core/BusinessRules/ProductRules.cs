using OnionArchitecture.Core.Enums;
using OnionArchitecture.Core.Interfaces;

namespace OnionArchitecture.Core.BusinessRules
{
    internal class ProductRules : IProductRules
    {
        public decimal GetProductPrice(ProductType productType)
        {
            return productType switch
            {
                ProductType.House => 400000,
                ProductType.Car => 50000,
                _ => throw new NotImplementedException()
            };
        }
    }
}
