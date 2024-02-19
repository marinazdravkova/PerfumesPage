using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Infrastructure.DataLayer.EntityMaps
{
    public class PerfumeMap : IEntityTypeConfiguration<Perfume>
    {
        public void Configure(EntityTypeBuilder<Perfume> builder)
        {
            builder.ToTable(nameof(Perfume));

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(p => p.Description)
                .IsRequired();

            builder.Property(p => p.ImageURL)
                .IsRequired();

            builder.Property(p => p.Price)
                .IsRequired();

            

            var perfumes = new Perfume[]
            {
                new Perfume
                {
                    Id = Guid.Parse("d5b6fe2e-fb22-404b-950c-4256200541ff"),
                    Name = "Tom Ford Ombre",
                    Description = "Мирисни ноти: Cardamom, Saffron, Jasmine sambac",
                    ImageURL = "https://fragrance.mk/wp-content/uploads/2022/05/tom-ford-ombre-leather-edp-1.jpg",
                    Price =  7590,
                    PerfumeType = "Машки/Женски",
                    BrandId = Guid.Parse("52b3642f-398c-4e0e-8292-5188ad694d0e"),
                    //UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                },

                 new Perfume
                {
                    Id = Guid.Parse("953f9f7d-9c90-4297-8dac-08594eb7073b"),
                    Name = "VALENTINO Uomo EDT",
                    Description = "Страста на римскиот дух доловена во микс од префинетата елеганција на нотите на ирис, ароматичниот ветивер и топлината на кардамон што ја обвива.e",
                    ImageURL = "https://fragrance.mk/wp-content/uploads/2021/02/valentino-uomo-edt-1-600x600.jpg",
                    Price =  5980,
                    PerfumeType = "Машки",
                    BrandId = Guid.Parse("52b3642f-398c-4e0e-8292-5188ad694d0e"),
                   // UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                },
                  new Perfume
                {
                    Id = Guid.Parse("c16acd8d-587b-4fc6-8fa1-511771ce5c3f"),
                    Name = "VERSACE Dylan Blue EDT",
                    Description = "Dylan Blue е ароматичнo-двенест состав со свежи водени ноти, калабриски бергамот, грејпфрут и лист од смоква. Срцето се развива со листови од љубичица, папирус, органски пачули, црн пипер и амброкс. -1024x1024.webp",
                    ImageURL = "https://fragrance.mk/wp-content/uploads/2023/03/versace-dylan-blue-edt-3.webp",
                    Price =  4220,
                    PerfumeType = "Машки",
                    BrandId = Guid.Parse("15e32544-1bc0-4602-a55e-c55cc9892bfb"),
                    //UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                },
                   new Perfume
                {
                    Id = Guid.Parse("7ec81a51-085a-4a98-b34e-14305e370636"),
                    Name = "CALVIN KLEIN CK One EDT",
                    Description = "Цитрусен и ароматски мирис за мажи и жени, претставен во 1994 година, креиран од Alberto Morillas и Harry Fremont. Горните ноти се ананас, зелени ноти, мандарина, папаја, бергамот, кардамон и лимон.",
                    ImageURL = "https://fragrance.mk/wp-content/uploads/2021/02/calvin-klein-ck-one-edt-1-600x600.jpg",
                    Price =  2580,
                    PerfumeType = "Машки/Женски",
                    BrandId = Guid.Parse("a5e6b706-c3bd-4a7d-96f4-348588956401"),
                   // UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                },
                    new Perfume
                {
                    Id = Guid.Parse("cf3a69a3-f416-4ae4-a8d6-6e01a09f3af2"),
                    Name = "GUESS Seductive EDT",
                    Description = "Guess го лансира Seductive во 2010 година. Мирисот го креира Veronique Nyberg од ноти на бергамот, црна рибизла, крушка, јасмин, цвет од портокал, корен од ирис, ванила и кашмир.",
                    ImageURL = "https://fragrance.mk/wp-content/uploads/2022/10/guess-seductive-edt-1-600x600.jpg",
                    Price =  3450,
                    PerfumeType = "Женски",
                    BrandId = Guid.Parse("38e4cb9e-974e-4468-a00c-7ae7b3ca3e24"),
                    //UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                },
                     new Perfume
                {
                    Id = Guid.Parse("6844a077-5416-4ba5-8d8d-cbad932fa597"),
                    Name = "VERSACE Crystal Noir EDP",
                    Description = "Според Donatela Versace, Crystal Noir, е ретка есенција, сензибилна и деликатна. Во центарот на композицијата е таинствената гарденија, свежа, сензуална, блескава и кремаста, која е репродуцирана со помош на ‘Headspace’ технологијата.",
                    ImageURL = "https://fragrance.mk/wp-content/uploads/2021/02/versace-crystal-noir-edp-1-600x600.jpg",
                    Price =  5700,
                    PerfumeType = "Женски",
                    BrandId = Guid.Parse("15e32544-1bc0-4602-a55e-c55cc9892bfb"),
                   // UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                },

                      new Perfume
                {
                    Id = Guid.Parse("92136b42-f8c5-4e31-9498-5d19b380a804"),
                    Name = "DIOR J’adore EDP",
                    Description = "J’adore е модерен, гламурозен мирис, кој стана неверојатно популарен и од таа причина се разви во голем број варијанти со различна концентрација.",
                    ImageURL = "https://fragrance.mk/wp-content/uploads/2021/02/dior-jadore-edp-1-600x600.jpg",
                    PerfumeType = "Женски",
                    BrandId = Guid.Parse("cab83c3d-b297-43ce-b73d-ba1ba601b15d"),
                   // UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                },

                      new Perfume
                {
                    Id = Guid.Parse("7f77d8ac-e6fd-4d51-940b-ca7002c3cd89"),
                    Name = "LANCOME O de Lancome EDT",
                    Description = "O de Lancome е цитрусен мирис за жени кој беше лансиран во 1969 година. Носот зад овој мирис е Robert Gonnon. O de Lancome е совршен за лето. Полн е со сончеви зраци и освежителни ноти.",
                    ImageURL = "https://fragrance.mk/wp-content/uploads/2022/01/lancome-o-de-lancome-edt-1-600x600.jpg",
                    PerfumeType = "Женски",
                    BrandId = Guid.Parse("3393477f-e724-4ac5-97ac-236641cbce40"),
                    //UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                },
            };

            builder.HasData(perfumes);


        }
    }
}
