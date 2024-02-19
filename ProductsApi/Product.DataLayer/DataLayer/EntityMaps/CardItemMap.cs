using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Products.Infrastructure.DataLayer.EntityMaps
{
    public class CardItemMap : IEntityTypeConfiguration<CardItem>
    {
        public void Configure(EntityTypeBuilder<CardItem> builder)
        {
            builder.ToTable(nameof(CardItem));

            builder.Property(d => d.Quantity)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(d => d.Price)
                .IsRequired()
                .HasMaxLength(50);

            

           
        }
    }
}
