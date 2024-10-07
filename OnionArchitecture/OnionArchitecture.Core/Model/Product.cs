using OnionArchitecture.Core.Enums;

namespace OnionArchitecture.Core.Model
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ProductType Type { get; set; }
    }
}
