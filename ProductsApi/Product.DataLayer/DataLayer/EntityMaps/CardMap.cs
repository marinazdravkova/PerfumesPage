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
    public class CardMap : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.ToTable(nameof(Card));

            builder.Property<DateTime>("CreatedOn")
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("(GetDate())");

            

            

        }
    }
}
