using System.Linq;
using HepsiBurada.Data.Context;
using HepsiBurada.Data.Repositories.Interfaces;
using HepsiBurada.Domain;

namespace HepsiBurada.Data.Repositories.Entity
{
    public class ProductRepository : IProductRepository
    {
        private readonly HepsiBuradaContext _context;

        public ProductRepository(HepsiBuradaContext context) => _context = context;

        public ProductRequestDto AddProduct(ProductRequestDto product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public ProductRequestDto FindByCode(string productCode)
        {
            return _context.Products.FirstOrDefault(x => x.ProductCode.ToLower().Contains(productCode.ToLower()));
        }
    }
}