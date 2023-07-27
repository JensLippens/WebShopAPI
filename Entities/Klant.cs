using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopAPI.Entities
{
    public class Klant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Naam { get; set; }

        [Required]
        public string Voornaam { get; set; }

        public string? Gemeente { get; set; }

        public string? Telefoon { get; set; }

        [Required]
        public string Email { get; set; }

        public ICollection<Order> Orders { get; set; }
            = new List<Order>();

        public Klant(string naam, string voornaam, string email)
        {
            Naam = naam;
            Voornaam = voornaam;
            Email = email;
        }
    }
}
