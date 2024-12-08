using BlazorShop.DataSeeder;
using BlazorShop.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.Price).HasColumnType("decimal(18,2)");
        });

        modelBuilder.Entity<Product>()
            .HasData(ProductDataSeeder.GenerateProductsData());
    }
}
