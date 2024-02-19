using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Product.DataLayer.Migrations
{
    public partial class initial_create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brand",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "dbo",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                schema: "dbo",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                schema: "dbo",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "dbo",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                schema: "dbo",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Perfume",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    PerfumeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Season = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfume", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Perfume_Brand_BrandId",
                        column: x => x.BrandId,
                        principalSchema: "dbo",
                        principalTable: "Brand",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Brand",
                columns: new[] { "Id", "Country", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("15e32544-1bc0-4602-a55e-c55cc9892bfb"), "Италија", "Gianni Versace is an Italian luxury fashion company founded by Gianni Versace in 1978 known for flashy prints and bright colors.", "VERSACE" },
                    { new Guid("3393477f-e724-4ac5-97ac-236641cbce40"), "Франција", "Lancôme е француска луксузна куќа за парфеми и козметика која дистрибуира производи на меѓународно ниво.", "Lancôme" },
                    { new Guid("38e4cb9e-974e-4468-a00c-7ae7b3ca3e24"), "Шпанија", "Guess е американска компанија за облека и додатоци, позната по своите црно-бели реклами.", "GUESS" },
                    { new Guid("52b3642f-398c-4e0e-8292-5188ad694d0e"), "Италија", "Валентино е меѓу лидерите на меѓународната мода кои веруваат во зголемената додадена вредност што произлегува од глобалната визија за стил, развиена преку колекциите на високата мода.", "VALENTINO" },
                    { new Guid("a1b1d541-a379-4592-a1a1-fa37694e879b"), "Швајцарија", "Том Форд е луксузна модна куќа основана од дизајнерот Том Форд во 2005 година.", "Tom Ford" },
                    { new Guid("a5e6b706-c3bd-4a7d-96f4-348588956401"), "Франција", "Calvin Klein е глобален бренд за животен стил кој е пример за смели, прогресивни идеали и заводлива, а честопати минимална, естетика.", "CALVIN KLEIN" },
                    { new Guid("cab83c3d-b297-43ce-b73d-ba1ba601b15d"), "Франција", "Christian Dior SE (Christian Dior) is a manufacturer, distributor and retailer of luxury goods.", "DIOR" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Perfume",
                columns: new[] { "Id", "BrandId", "Description", "ImageURL", "Name", "PerfumeType", "Price", "Season" },
                values: new object[,]
                {
                    { new Guid("6844a077-5416-4ba5-8d8d-cbad932fa597"), new Guid("15e32544-1bc0-4602-a55e-c55cc9892bfb"), "Според Donatela Versace, Crystal Noir, е ретка есенција, сензибилна и деликатна. Во центарот на композицијата е таинствената гарденија, свежа, сензуална, блескава и кремаста, која е репродуцирана со помош на ‘Headspace’ технологијата.", "https://fragrance.mk/wp-content/uploads/2021/02/versace-crystal-noir-edp-1-600x600.jpg", "VERSACE Crystal Noir EDP", "Женски", 5700, null },
                    { new Guid("7ec81a51-085a-4a98-b34e-14305e370636"), new Guid("a5e6b706-c3bd-4a7d-96f4-348588956401"), "Цитрусен и ароматски мирис за мажи и жени, претставен во 1994 година, креиран од Alberto Morillas и Harry Fremont. Горните ноти се ананас, зелени ноти, мандарина, папаја, бергамот, кардамон и лимон.", "https://fragrance.mk/wp-content/uploads/2021/02/calvin-klein-ck-one-edt-1-600x600.jpg", "CALVIN KLEIN CK One EDT", "Машки/Женски", 2580, null },
                    { new Guid("7f77d8ac-e6fd-4d51-940b-ca7002c3cd89"), new Guid("3393477f-e724-4ac5-97ac-236641cbce40"), "O de Lancome е цитрусен мирис за жени кој беше лансиран во 1969 година. Носот зад овој мирис е Robert Gonnon. O de Lancome е совршен за лето. Полн е со сончеви зраци и освежителни ноти.", "https://fragrance.mk/wp-content/uploads/2022/01/lancome-o-de-lancome-edt-1-600x600.jpg", "LANCOME O de Lancome EDT", "Женски", 0, null },
                    { new Guid("92136b42-f8c5-4e31-9498-5d19b380a804"), new Guid("cab83c3d-b297-43ce-b73d-ba1ba601b15d"), "J’adore е модерен, гламурозен мирис, кој стана неверојатно популарен и од таа причина се разви во голем број варијанти со различна концентрација.", "https://fragrance.mk/wp-content/uploads/2021/02/dior-jadore-edp-1-600x600.jpg", "DIOR J’adore EDP", "Женски", 0, null },
                    { new Guid("953f9f7d-9c90-4297-8dac-08594eb7073b"), new Guid("52b3642f-398c-4e0e-8292-5188ad694d0e"), "Страста на римскиот дух доловена во микс од префинетата елеганција на нотите на ирис, ароматичниот ветивер и топлината на кардамон што ја обвива.e", "https://fragrance.mk/wp-content/uploads/2021/02/valentino-uomo-edt-1-600x600.jpg", "VALENTINO Uomo EDT", "Машки", 5980, null },
                    { new Guid("c16acd8d-587b-4fc6-8fa1-511771ce5c3f"), new Guid("15e32544-1bc0-4602-a55e-c55cc9892bfb"), "Dylan Blue е ароматичнo-двенест состав со свежи водени ноти, калабриски бергамот, грејпфрут и лист од смоква. Срцето се развива со листови од љубичица, папирус, органски пачули, црн пипер и амброкс. -1024x1024.webp", "https://fragrance.mk/wp-content/uploads/2023/03/versace-dylan-blue-edt-3.webp", "VERSACE Dylan Blue EDT", "Машки", 4220, null },
                    { new Guid("cf3a69a3-f416-4ae4-a8d6-6e01a09f3af2"), new Guid("38e4cb9e-974e-4468-a00c-7ae7b3ca3e24"), "Guess го лансира Seductive во 2010 година. Мирисот го креира Veronique Nyberg од ноти на бергамот, црна рибизла, крушка, јасмин, цвет од портокал, корен од ирис, ванила и кашмир.", "https://fragrance.mk/wp-content/uploads/2022/10/guess-seductive-edt-1-600x600.jpg", "GUESS Seductive EDT", "Женски", 3450, null },
                    { new Guid("d5b6fe2e-fb22-404b-950c-4256200541ff"), new Guid("52b3642f-398c-4e0e-8292-5188ad694d0e"), "Мирисни ноти: Cardamom, Saffron, Jasmine sambac", "https://fragrance.mk/wp-content/uploads/2022/05/tom-ford-ombre-leather-edp-1.jpg", "Tom Ford Ombre", "Машки/Женски", 7590, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "dbo",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "dbo",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "dbo",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "dbo",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "dbo",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "dbo",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "dbo",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Perfume_BrandId",
                schema: "dbo",
                table: "Perfume",
                column: "BrandId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Perfume",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetRoles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Brand",
                schema: "dbo");
        }
    }
}
