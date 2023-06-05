using HahnRaphaelWeb.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace HahnRaphaelWeb.Infrastructure.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(x => x.Id);
            modelBuilder.Entity<Product>().Property(x => x.Name).HasMaxLength(25);
            modelBuilder.Entity<Product>().Property(x => x.Description).HasMaxLength(255);
            modelBuilder.Entity<Product>().Property(x => x.Price);
            modelBuilder.Entity<Product>().HasIndex(b => b.Id);

        }
    }
}
