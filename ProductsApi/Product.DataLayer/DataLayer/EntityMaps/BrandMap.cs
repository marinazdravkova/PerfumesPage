using Microsoft.EntityFrameworkCore;
using Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Infrastructure.DataLayer.EntityMaps
{
    public class BrandMap : IEntityTypeConfiguration<Brand>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable(nameof(Brand));

            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(b => b.Description)
                .IsRequired()
                .HasMaxLength(250);

            
            var brands = new Brand[]
            {
                new Brand
                {
                    Id = Guid.Parse("a1b1d541-a379-4592-a1a1-fa37694e879b"),
                    Name = "Tom Ford",
                    Description = "Том Форд е луксузна модна куќа основана од дизајнерот Том Форд во 2005 година.",
                    Country = "Швајцарија",
                    //UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                },

                new Brand
                {
                    Id = Guid.Parse("3393477f-e724-4ac5-97ac-236641cbce40"),
                    Name = "Lancôme",
                    Description = "Lancôme е француска луксузна куќа за парфеми и козметика која дистрибуира производи на меѓународно ниво.",
                    Country = "Франција",
                    //UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                },

                new Brand
                {
                    Id = Guid.Parse("cab83c3d-b297-43ce-b73d-ba1ba601b15d"),
                    Name = "DIOR",
                    Description = "Christian Dior SE (Christian Dior) is a manufacturer, distributor and retailer of luxury goods.",
                    Country = "Франција",
                    //UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                },

                new Brand
                {
                    Id= Guid.Parse("15e32544-1bc0-4602-a55e-c55cc9892bfb"),
                    Name = "VERSACE",
                    Description = "Gianni Versace is an Italian luxury fashion company founded by Gianni Versace in 1978 known for flashy prints and bright colors.",
                    Country = "Италија",
                   // UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                },
                new Brand
                {
                    Id= Guid.Parse("52b3642f-398c-4e0e-8292-5188ad694d0e"),
                    Name = "VALENTINO",
                    Description = "Валентино е меѓу лидерите на меѓународната мода кои веруваат во зголемената додадена вредност што произлегува од глобалната визија за стил, развиена преку колекциите на високата мода.",
                    Country = "Италија",
                   // UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                },
                new Brand
                {
                    Id= Guid.Parse("a5e6b706-c3bd-4a7d-96f4-348588956401"),
                    Name = "CALVIN KLEIN",
                    Description = "Calvin Klein е глобален бренд за животен стил кој е пример за смели, прогресивни идеали и заводлива, а честопати минимална, естетика.",
                    Country = "Франција",
                    //UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                },

                new Brand
                {
                    Id= Guid.Parse("38e4cb9e-974e-4468-a00c-7ae7b3ca3e24"),
                    Name = "GUESS",
                    Description = "Guess е американска компанија за облека и додатоци, позната по своите црно-бели реклами.",
                    Country = "Шпанија",
                   // UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                }

            };

            builder.HasData(brands);
        }
    }
}
