using OnionArchitecture.Core.Interfaces;
using OnionArchitecture.Core.Model;

namespace OnionArchitecture.Core.Validations
{
    internal class ProductValidations : IProductValidations
    {
        public bool IsValid(Product product)
        {
            return product.Price > 0;
        }
    }
}
