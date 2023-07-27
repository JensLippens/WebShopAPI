using WebShopAPI.Entities;

namespace WebShopAPI.Services
{
    public interface IWebShopRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product?> GetProductAsync(int productId);

        void AddProductAsync(Product product);
        void DeleteProduct(Product product);

        Task<bool> SaveChangesAsync();

    }
}

