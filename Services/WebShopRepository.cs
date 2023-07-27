using Microsoft.EntityFrameworkCore;
using WebShopAPI.DbContexts;
using WebShopAPI.Entities;

namespace WebShopAPI.Services
{
    public class WebShopRepository : IWebShopRepository
    {
        private readonly WebShopContext _context;

        public WebShopRepository(WebShopContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _context.Products.OrderBy(p => p.Name).ToListAsync();
        }
        public async Task<Product?> GetProductAsync(int productId)
        {
            return await _context.Products.Where(p => p.Id == productId).FirstOrDefaultAsync();
        }

        public void AddProductAsync(Product product)
        {
            _context.Products.Add(product);
        }

        public void DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
        }


        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
