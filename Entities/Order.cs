using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopAPI.Entities
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal TotaalPrijs { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();  

        [ForeignKey("KlantId")]
        public Klant Klant { get; set; } = null!;
        public int KlantId { get; set; }
    }
}
