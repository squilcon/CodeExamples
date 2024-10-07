using OnionArchitecture.Core.Enums;
using OnionArchitecture.Core.Interfaces;
using OnionArchitecture.Core.Model;

namespace OnionArchitecture.Services
{
    internal class ProductServices : IProductServices
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductRules _productRules;
        private readonly IProductValidations _productValidations;

        public ProductServices(
            IProductRepository productRepository,
            IProductRules productRules,
            IProductValidations productValidations)
        {
            _productRepository = productRepository;
            _productRules = productRules;
            _productValidations = productValidations;
        }

        public bool BuyProducts(ProductType productType)
        {
            var price = _productRules.GetProductPrice(productType);
            var product = new Product()
            {
                Type = productType,
                Price = price,
                Name = "ProductName",
                Description = "ProductDescription"
            };

            if (_productValidations.IsValid(product))
            {
                _productRepository.SaveProduct(product);
                return true;
            }

            return false;
        }
    }
}
