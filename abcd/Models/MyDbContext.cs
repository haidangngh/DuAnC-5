using Assignment_PH35423.Models.Table;
using Microsoft.EntityFrameworkCore;
using PH33706database.Models.Table;

namespace abcd.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Cart_Detail > Cart_Detail { get; set; }
        public DbSet<Carts > Carts { get; set; }
        public DbSet<Products > Products { get; set; }
        public DbSet<Customers > Customers { get; set; }
        public DbSet<Categories > Categories { get; set; }
        public DbSet<ProductsBrand> productsBrands { get; set; }
        public DbSet<ProductsCamera> productsCameras { get; set; }
        public DbSet<ProductsDisplay> productsDisplays { get; set; }
        public DbSet<Vounchers> vounchers { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetails> BillDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-MN98SD2\SQLEXPRESS;Initial Catalog=C#5ASMM;Integrated Security=True;Trust Server Certificate=True");
            //optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=DuAn1_C#;Integrated Security=True ; TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasIndex(e => e.IMEI).IsUnique();
            });
            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasIndex(e => e.PhoneNumber).IsUnique();
            });

            modelBuilder.Entity<Carts>(entity =>
            {
                entity.HasIndex(e => e.IdCustomers).IsUnique();
            });
        }
    }
}
