using OnionArchitecture.Core.Model;

namespace OnionArchitecture.Core.Interfaces
{
    public interface IProductValidations
    {
        bool IsValid(Product product);
    }
}