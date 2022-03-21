using HepsiBurada.Domain;

namespace HepsiBurada.Data.Repositories.Interfaces
{
    public interface IProductRepository
    {
        ProductRequestDto AddProduct(ProductRequestDto product);
        ProductRequestDto FindByCode(string productCode);
    }
}