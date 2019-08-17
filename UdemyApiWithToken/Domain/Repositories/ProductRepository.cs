using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UdemyApiWithToken.Domain.Model;

namespace UdemyApiWithToken.Domain.Repositories
{
    public class ProductRepository :BaseRepository,IProductRepository
    {
        public ProductRepository(UdemyApiWithTokenContext udemyApiWithTokenContext)
            : base(udemyApiWithTokenContext)
        {
        }
        public  async Task<IEnumerable<Product>> ListAsync()
        {
          return await _udemyApiWithTokenContext.Product.ToListAsync();
        }

        public async Task AddProductAsync(Product product)
        {
            await _udemyApiWithTokenContext.AddAsync(product);
        }

        public async Task RemoveProductAsync(int productId)
        {
            var product = await this.FindByIdAsync(productId);
             _udemyApiWithTokenContext.Remove(product);
        }

        public  void UpdateProduct(Product product)
        {
            _udemyApiWithTokenContext.Product.Update(product);
        }

        public async Task<Product> FindByIdAsync(int productId)
        {
            return await _udemyApiWithTokenContext.Product.FindAsync(productId);
        }
    }
}
