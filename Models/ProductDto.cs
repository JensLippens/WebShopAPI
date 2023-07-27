using System.ComponentModel.DataAnnotations;
using WebShopAPI.Entities;

namespace WebShopAPI.Models
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Inhoud { get; set; }
        public Categorie Categorie { get; set; }

        public int AantalKeerBesteld
        {
            get
            {
                return OrderItems.Count;
            }
        }
        public ICollection<OrderItem> OrderItems { get; set; }
            = new List<OrderItem>();
    }
}
