using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Products.Application.Common.Interfaces;
using Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Infrastructure.DataLayer
{
    public class ProductDbContext : IdentityDbContext<ApplicationUser>, IProductDbContext
    {
        public ProductDbContext() { }

        public ProductDbContext(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-G5I7932\\SQLEXPRESS;Database=ProductWebApi;Trusted_Connection=True;");
            }
        }

        public DbSet<Perfume> Perfumes => Set<Perfume>();
        public DbSet<Brand> Brands => Set<Brand>();
        public DbSet<Card> Cards => Set<Card>();
        public DbSet<CardItem> CardItems => Set<CardItem>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("dbo");
            builder.ApplyConfigurationsFromAssembly(typeof(ProductDbContext).Assembly);
            base.OnModelCreating(builder);
        }

        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
    }
}
