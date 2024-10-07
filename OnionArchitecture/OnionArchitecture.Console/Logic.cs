using OnionArchitecture.Core.Enums;
using OnionArchitecture.Core.Interfaces;

namespace OnionArchitecture.Console
{
    internal class Logic : ILogic
    {
        private readonly IProductServices _productServices;

        public Logic(IProductServices productServices)
        {
            _productServices = productServices;
        }

        public void Start()
        {
            var carBought = _productServices.BuyProducts(ProductType.Car);
            var housseBought = _productServices.BuyProducts(ProductType.House);
        }
    }
}
