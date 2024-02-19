using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Product.DataLayer.Migrations
{
    public partial class addbaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BrandId1",
                schema: "dbo",
                table: "Perfume",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                schema: "dbo",
                table: "Perfume",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                schema: "dbo",
                table: "Perfume",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                schema: "dbo",
                table: "Perfume",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                schema: "dbo",
                table: "Brand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                schema: "dbo",
                table: "Brand",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                schema: "dbo",
                table: "Brand",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c", 0, "60f87ae1-4df1-4be5-9e7e-7a3fcb882025", "Macedonia", "test@test.com", false, false, null, null, null, null, null, false, "3c49da89-d00f-4246-9b7f-4efa859dad46", false, null });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Brand",
                keyColumn: "Id",
                keyValue: new Guid("15e32544-1bc0-4602-a55e-c55cc9892bfb"),
                column: "UserId",
                value: "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Brand",
                keyColumn: "Id",
                keyValue: new Guid("3393477f-e724-4ac5-97ac-236641cbce40"),
                column: "UserId",
                value: "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Brand",
                keyColumn: "Id",
                keyValue: new Guid("38e4cb9e-974e-4468-a00c-7ae7b3ca3e24"),
                column: "UserId",
                value: "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Brand",
                keyColumn: "Id",
                keyValue: new Guid("52b3642f-398c-4e0e-8292-5188ad694d0e"),
                column: "UserId",
                value: "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Brand",
                keyColumn: "Id",
                keyValue: new Guid("a1b1d541-a379-4592-a1a1-fa37694e879b"),
                column: "UserId",
                value: "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Brand",
                keyColumn: "Id",
                keyValue: new Guid("a5e6b706-c3bd-4a7d-96f4-348588956401"),
                column: "UserId",
                value: "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Brand",
                keyColumn: "Id",
                keyValue: new Guid("cab83c3d-b297-43ce-b73d-ba1ba601b15d"),
                column: "UserId",
                value: "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Perfume",
                keyColumn: "Id",
                keyValue: new Guid("6844a077-5416-4ba5-8d8d-cbad932fa597"),
                column: "UserId",
                value: "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Perfume",
                keyColumn: "Id",
                keyValue: new Guid("7ec81a51-085a-4a98-b34e-14305e370636"),
                column: "UserId",
                value: "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Perfume",
                keyColumn: "Id",
                keyValue: new Guid("7f77d8ac-e6fd-4d51-940b-ca7002c3cd89"),
                column: "UserId",
                value: "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Perfume",
                keyColumn: "Id",
                keyValue: new Guid("92136b42-f8c5-4e31-9498-5d19b380a804"),
                column: "UserId",
                value: "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Perfume",
                keyColumn: "Id",
                keyValue: new Guid("953f9f7d-9c90-4297-8dac-08594eb7073b"),
                column: "UserId",
                value: "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Perfume",
                keyColumn: "Id",
                keyValue: new Guid("c16acd8d-587b-4fc6-8fa1-511771ce5c3f"),
                column: "UserId",
                value: "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Perfume",
                keyColumn: "Id",
                keyValue: new Guid("cf3a69a3-f416-4ae4-a8d6-6e01a09f3af2"),
                column: "UserId",
                value: "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Perfume",
                keyColumn: "Id",
                keyValue: new Guid("d5b6fe2e-fb22-404b-950c-4256200541ff"),
                column: "UserId",
                value: "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c");

            migrationBuilder.CreateIndex(
                name: "IX_Perfume_BrandId1",
                schema: "dbo",
                table: "Perfume",
                column: "BrandId1");

            migrationBuilder.CreateIndex(
                name: "IX_Perfume_UserId",
                schema: "dbo",
                table: "Perfume",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Brand_UserId",
                schema: "dbo",
                table: "Brand",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Brand_AspNetUsers_UserId",
                schema: "dbo",
                table: "Brand",
                column: "UserId",
                principalSchema: "dbo",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Perfume_AspNetUsers_UserId",
                schema: "dbo",
                table: "Perfume",
                column: "UserId",
                principalSchema: "dbo",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Perfume_Brand_BrandId1",
                schema: "dbo",
                table: "Perfume",
                column: "BrandId1",
                principalSchema: "dbo",
                principalTable: "Brand",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brand_AspNetUsers_UserId",
                schema: "dbo",
                table: "Brand");

            migrationBuilder.DropForeignKey(
                name: "FK_Perfume_AspNetUsers_UserId",
                schema: "dbo",
                table: "Perfume");

            migrationBuilder.DropForeignKey(
                name: "FK_Perfume_Brand_BrandId1",
                schema: "dbo",
                table: "Perfume");

            migrationBuilder.DropIndex(
                name: "IX_Perfume_BrandId1",
                schema: "dbo",
                table: "Perfume");

            migrationBuilder.DropIndex(
                name: "IX_Perfume_UserId",
                schema: "dbo",
                table: "Perfume");

            migrationBuilder.DropIndex(
                name: "IX_Brand_UserId",
                schema: "dbo",
                table: "Brand");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c");

            migrationBuilder.DropColumn(
                name: "BrandId1",
                schema: "dbo",
                table: "Perfume");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                schema: "dbo",
                table: "Perfume");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                schema: "dbo",
                table: "Perfume");

            migrationBuilder.DropColumn(
                name: "UserId",
                schema: "dbo",
                table: "Perfume");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                schema: "dbo",
                table: "Brand");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                schema: "dbo",
                table: "Brand");

            migrationBuilder.DropColumn(
                name: "UserId",
                schema: "dbo",
                table: "Brand");
        }
    }
}
