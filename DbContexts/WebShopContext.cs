using Microsoft.EntityFrameworkCore;
using WebShopAPI.Entities;

namespace WebShopAPI.DbContexts
{
    public class WebShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<OrderItem> OrderItems { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Klant> Klanten { get; set; } = null!;

        public WebShopContext(DbContextOptions<WebShopContext> options)
           : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasData(
               new Product(
                   "Verhelderende primer",
                   "Gebruikstest gedurende vier weken bij een panel van 26 vrouwen. 85% doeltreffend",
                   19.9m,
                   25,
                  Categorie.Makeup.ToString())
               {
                   Id = 1,
               },
               new Product(
                   "Restructuring care",
                   "Het ultra-geconcentreerde Aphloia-extract bestrijdt de schadelijke factoren die het huidverouderingsproces versnellen. 90% doeltreffend",
                   18.45m,
                   50,
                   Categorie.Gelaat.ToString())
               {
                   Id = 2,
               },
               new Product(
                   "Comme une Evidence - Eau de Parfum",
                   "De verfijnde frisheid van Bergamotessence maakt vrij baan voor de subtiel vrouwelijke nasleep van absolue van Damascusroos",
                   54.95m,
                   100,
                   Categorie.Parfum.ToString())
               {
                   Id = 3,
               });

            base.OnModelCreating(modelBuilder);
        }
    }
}
