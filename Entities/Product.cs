using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopAPI.Entities
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        [Required]
        [Range(0, Double.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Inhoud { get;set; } 

        [Required]
        public string Categorie { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
            = new List<OrderItem>();

        public Product(string name, string description, decimal price, int inhoud, string categorie)
        {
            Name = name;
            Description = description;
            Price = price;
            Inhoud = inhoud;
            Categorie = categorie;
        }
    }

    public enum Categorie {
        Gelaat,
        Haar,
        Douche,
        Makeup,
        Parfum
    }
}
