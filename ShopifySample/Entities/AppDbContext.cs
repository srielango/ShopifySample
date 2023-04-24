using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Runtime.Intrinsics.X86;

namespace ShopifySample.Entities
{
    public partial class AppDbContext : DbContext
    {
        public virtual DbSet<Shopify_Product> Shopify_Products { get; set; }
        public virtual DbSet<Shopify_ProductImage> Shopify_ProductImages { get; set; }
        public virtual DbSet<Shopify_Product_Variant> Shopify_Product_Variants { get; set; }
        public virtual DbSet<Shopify_ProductOption> Shopify_ProductOptions { get; set; }
        // public virtual DbSet<List<long>> Product_Ids { get; set; }   //TODO: Code that generates the error "The entity type 'List<long>' requires a primary key to be defined. If you intended to use a keyless entity type, call 'HasNoKey' in 'OnModelCreating'. For more information on keyless entity types, see https://go.microsoft.com/fwlink/?linkid=2141943."

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-UCD8246\\MSSQLSERVER01;Database=ShopifySample;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shopify_Product>().HasKey(e => e.ID);
            modelBuilder.Entity<Shopify_Product_Variant>().HasKey(e => e.ID);
            modelBuilder.Entity<Shopify_ProductOption>().HasKey(e => e.ID);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
