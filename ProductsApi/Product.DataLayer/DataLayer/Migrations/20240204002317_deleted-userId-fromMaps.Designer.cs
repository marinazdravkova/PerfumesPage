﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Products.Infrastructure.DataLayer;

#nullable disable

namespace Product.DataLayer.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20240204002317_deleted-userId-fromMaps")]
    partial class deleteduserIdfromMaps
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", "dbo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", "dbo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", "dbo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", "dbo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", "dbo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", "dbo");
                });

            modelBuilder.Entity("Products.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", "dbo");

                    b.HasData(
                        new
                        {
                            Id = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9712319c-dadc-420a-bb5a-c13569af1800",
                            Country = "Macedonia",
                            Email = "test@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "88d9664d-dae0-440f-8f86-65cc4ca26e49",
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("Products.Entities.Brand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Brand", "dbo");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a1b1d541-a379-4592-a1a1-fa37694e879b"),
                            Country = "Швајцарија",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Том Форд е луксузна модна куќа основана од дизајнерот Том Форд во 2005 година.",
                            Name = "Tom Ford",
                            UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c"
                        },
                        new
                        {
                            Id = new Guid("3393477f-e724-4ac5-97ac-236641cbce40"),
                            Country = "Франција",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lancôme е француска луксузна куќа за парфеми и козметика која дистрибуира производи на меѓународно ниво.",
                            Name = "Lancôme",
                            UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c"
                        },
                        new
                        {
                            Id = new Guid("cab83c3d-b297-43ce-b73d-ba1ba601b15d"),
                            Country = "Франција",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Christian Dior SE (Christian Dior) is a manufacturer, distributor and retailer of luxury goods.",
                            Name = "DIOR",
                            UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c"
                        },
                        new
                        {
                            Id = new Guid("15e32544-1bc0-4602-a55e-c55cc9892bfb"),
                            Country = "Италија",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Gianni Versace is an Italian luxury fashion company founded by Gianni Versace in 1978 known for flashy prints and bright colors.",
                            Name = "VERSACE",
                            UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c"
                        },
                        new
                        {
                            Id = new Guid("52b3642f-398c-4e0e-8292-5188ad694d0e"),
                            Country = "Италија",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Валентино е меѓу лидерите на меѓународната мода кои веруваат во зголемената додадена вредност што произлегува од глобалната визија за стил, развиена преку колекциите на високата мода.",
                            Name = "VALENTINO",
                            UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c"
                        },
                        new
                        {
                            Id = new Guid("a5e6b706-c3bd-4a7d-96f4-348588956401"),
                            Country = "Франција",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Calvin Klein е глобален бренд за животен стил кој е пример за смели, прогресивни идеали и заводлива, а честопати минимална, естетика.",
                            Name = "CALVIN KLEIN",
                            UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c"
                        },
                        new
                        {
                            Id = new Guid("38e4cb9e-974e-4468-a00c-7ae7b3ca3e24"),
                            Country = "Шпанија",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Guess е американска компанија за облека и додатоци, позната по своите црно-бели реклами.",
                            Name = "GUESS",
                            UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c"
                        });
                });

            modelBuilder.Entity("Products.Entities.Card", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("(GetDate())");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Card", "dbo");
                });

            modelBuilder.Entity("Products.Entities.CardItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CardId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PerfumeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasMaxLength(50)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasMaxLength(30)
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("PerfumeId");

                    b.HasIndex("UserId");

                    b.ToTable("CardItem", "dbo");
                });

            modelBuilder.Entity("Products.Entities.Perfume", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BrandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("PerfumeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Season")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("UserId");

                    b.ToTable("Perfume", "dbo");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d5b6fe2e-fb22-404b-950c-4256200541ff"),
                            BrandId = new Guid("52b3642f-398c-4e0e-8292-5188ad694d0e"),
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Мирисни ноти: Cardamom, Saffron, Jasmine sambac",
                            ImageURL = "https://fragrance.mk/wp-content/uploads/2022/05/tom-ford-ombre-leather-edp-1.jpg",
                            Name = "Tom Ford Ombre",
                            PerfumeType = "Машки/Женски",
                            Price = 7590,
                            UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c"
                        },
                        new
                        {
                            Id = new Guid("953f9f7d-9c90-4297-8dac-08594eb7073b"),
                            BrandId = new Guid("52b3642f-398c-4e0e-8292-5188ad694d0e"),
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Страста на римскиот дух доловена во микс од префинетата елеганција на нотите на ирис, ароматичниот ветивер и топлината на кардамон што ја обвива.e",
                            ImageURL = "https://fragrance.mk/wp-content/uploads/2021/02/valentino-uomo-edt-1-600x600.jpg",
                            Name = "VALENTINO Uomo EDT",
                            PerfumeType = "Машки",
                            Price = 5980,
                            UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c"
                        },
                        new
                        {
                            Id = new Guid("c16acd8d-587b-4fc6-8fa1-511771ce5c3f"),
                            BrandId = new Guid("15e32544-1bc0-4602-a55e-c55cc9892bfb"),
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Dylan Blue е ароматичнo-двенест состав со свежи водени ноти, калабриски бергамот, грејпфрут и лист од смоква. Срцето се развива со листови од љубичица, папирус, органски пачули, црн пипер и амброкс. -1024x1024.webp",
                            ImageURL = "https://fragrance.mk/wp-content/uploads/2023/03/versace-dylan-blue-edt-3.webp",
                            Name = "VERSACE Dylan Blue EDT",
                            PerfumeType = "Машки",
                            Price = 4220,
                            UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c"
                        },
                        new
                        {
                            Id = new Guid("7ec81a51-085a-4a98-b34e-14305e370636"),
                            BrandId = new Guid("a5e6b706-c3bd-4a7d-96f4-348588956401"),
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Цитрусен и ароматски мирис за мажи и жени, претставен во 1994 година, креиран од Alberto Morillas и Harry Fremont. Горните ноти се ананас, зелени ноти, мандарина, папаја, бергамот, кардамон и лимон.",
                            ImageURL = "https://fragrance.mk/wp-content/uploads/2021/02/calvin-klein-ck-one-edt-1-600x600.jpg",
                            Name = "CALVIN KLEIN CK One EDT",
                            PerfumeType = "Машки/Женски",
                            Price = 2580,
                            UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c"
                        },
                        new
                        {
                            Id = new Guid("cf3a69a3-f416-4ae4-a8d6-6e01a09f3af2"),
                            BrandId = new Guid("38e4cb9e-974e-4468-a00c-7ae7b3ca3e24"),
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Guess го лансира Seductive во 2010 година. Мирисот го креира Veronique Nyberg од ноти на бергамот, црна рибизла, крушка, јасмин, цвет од портокал, корен од ирис, ванила и кашмир.",
                            ImageURL = "https://fragrance.mk/wp-content/uploads/2022/10/guess-seductive-edt-1-600x600.jpg",
                            Name = "GUESS Seductive EDT",
                            PerfumeType = "Женски",
                            Price = 3450,
                            UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c"
                        },
                        new
                        {
                            Id = new Guid("6844a077-5416-4ba5-8d8d-cbad932fa597"),
                            BrandId = new Guid("15e32544-1bc0-4602-a55e-c55cc9892bfb"),
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Според Donatela Versace, Crystal Noir, е ретка есенција, сензибилна и деликатна. Во центарот на композицијата е таинствената гарденија, свежа, сензуална, блескава и кремаста, која е репродуцирана со помош на ‘Headspace’ технологијата.",
                            ImageURL = "https://fragrance.mk/wp-content/uploads/2021/02/versace-crystal-noir-edp-1-600x600.jpg",
                            Name = "VERSACE Crystal Noir EDP",
                            PerfumeType = "Женски",
                            Price = 5700,
                            UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c"
                        },
                        new
                        {
                            Id = new Guid("92136b42-f8c5-4e31-9498-5d19b380a804"),
                            BrandId = new Guid("cab83c3d-b297-43ce-b73d-ba1ba601b15d"),
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "J’adore е модерен, гламурозен мирис, кој стана неверојатно популарен и од таа причина се разви во голем број варијанти со различна концентрација.",
                            ImageURL = "https://fragrance.mk/wp-content/uploads/2021/02/dior-jadore-edp-1-600x600.jpg",
                            Name = "DIOR J’adore EDP",
                            PerfumeType = "Женски",
                            Price = 0,
                            UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c"
                        },
                        new
                        {
                            Id = new Guid("7f77d8ac-e6fd-4d51-940b-ca7002c3cd89"),
                            BrandId = new Guid("3393477f-e724-4ac5-97ac-236641cbce40"),
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "O de Lancome е цитрусен мирис за жени кој беше лансиран во 1969 година. Носот зад овој мирис е Robert Gonnon. O de Lancome е совршен за лето. Полн е со сончеви зраци и освежителни ноти.",
                            ImageURL = "https://fragrance.mk/wp-content/uploads/2022/01/lancome-o-de-lancome-edt-1-600x600.jpg",
                            Name = "LANCOME O de Lancome EDT",
                            PerfumeType = "Женски",
                            Price = 0,
                            UserId = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Products.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Products.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Products.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Products.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Products.Entities.Brand", b =>
                {
                    b.HasOne("Products.Entities.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Products.Entities.Card", b =>
                {
                    b.HasOne("Products.Entities.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Products.Entities.CardItem", b =>
                {
                    b.HasOne("Products.Entities.Card", "Card")
                        .WithMany("Items")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Products.Entities.Perfume", "Perfume")
                        .WithMany()
                        .HasForeignKey("PerfumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Products.Entities.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("Perfume");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Products.Entities.Perfume", b =>
                {
                    b.HasOne("Products.Entities.Brand", "Brand")
                        .WithMany("Perfumes")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Products.Entities.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Products.Entities.Brand", b =>
                {
                    b.Navigation("Perfumes");
                });

            modelBuilder.Entity("Products.Entities.Card", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
