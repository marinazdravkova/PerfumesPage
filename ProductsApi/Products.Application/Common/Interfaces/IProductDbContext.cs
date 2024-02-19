using Microsoft.EntityFrameworkCore;
using Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Common.Interfaces
{
    public interface IProductDbContext
    {
        //Ovoj interfejs ke go koristime oti vo ovoj proekt ke ni se repository
        public DbSet<Perfume> Perfumes { get; }
        public DbSet<Brand> Brands { get; }
        public DbSet<Card> Cards { get; }

        public Task<int> SaveChangesAsync();
    }
}
