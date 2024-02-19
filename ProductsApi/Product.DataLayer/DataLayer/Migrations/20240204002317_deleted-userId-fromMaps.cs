using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Product.DataLayer.Migrations
{
    public partial class deleteduserIdfromMaps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brand_AspNetUsers_UserId",
                schema: "dbo",
                table: "Brand");

            migrationBuilder.DropForeignKey(
                name: "FK_Card_AspNetUsers_UserId",
                schema: "dbo",
                table: "Card");

            migrationBuilder.DropForeignKey(
                name: "FK_CardItem_AspNetUsers_UserId",
                schema: "dbo",
                table: "CardItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CardItem_Perfume_PerfumeId",
                schema: "dbo",
                table: "CardItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Perfume_AspNetUsers_UserId",
                schema: "dbo",
                table: "Perfume");

            migrationBuilder.DropForeignKey(
                name: "FK_Perfume_Brand_BrandId",
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

            migrationBuilder.DropColumn(
                name: "BrandId1",
                schema: "dbo",
                table: "Perfume");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9712319c-dadc-420a-bb5a-c13569af1800", "88d9664d-dae0-440f-8f86-65cc4ca26e49" });

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
                name: "FK_Card_AspNetUsers_UserId",
                schema: "dbo",
                table: "Card",
                column: "UserId",
                principalSchema: "dbo",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardItem_AspNetUsers_UserId",
                schema: "dbo",
                table: "CardItem",
                column: "UserId",
                principalSchema: "dbo",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CardItem_Perfume_PerfumeId",
                schema: "dbo",
                table: "CardItem",
                column: "PerfumeId",
                principalSchema: "dbo",
                principalTable: "Perfume",
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
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Perfume_Brand_BrandId",
                schema: "dbo",
                table: "Perfume",
                column: "BrandId",
                principalSchema: "dbo",
                principalTable: "Brand",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brand_AspNetUsers_UserId",
                schema: "dbo",
                table: "Brand");

            migrationBuilder.DropForeignKey(
                name: "FK_Card_AspNetUsers_UserId",
                schema: "dbo",
                table: "Card");

            migrationBuilder.DropForeignKey(
                name: "FK_CardItem_AspNetUsers_UserId",
                schema: "dbo",
                table: "CardItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CardItem_Perfume_PerfumeId",
                schema: "dbo",
                table: "CardItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Perfume_AspNetUsers_UserId",
                schema: "dbo",
                table: "Perfume");

            migrationBuilder.DropForeignKey(
                name: "FK_Perfume_Brand_BrandId",
                schema: "dbo",
                table: "Perfume");

            migrationBuilder.AddColumn<Guid>(
                name: "BrandId1",
                schema: "dbo",
                table: "Perfume",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1295ca20-3a13-4bf1-9e87-fe7441871812", "1ba26a55-834d-475e-aa74-4bd8fdac4de9" });

            migrationBuilder.CreateIndex(
                name: "IX_Perfume_BrandId1",
                schema: "dbo",
                table: "Perfume",
                column: "BrandId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Brand_AspNetUsers_UserId",
                schema: "dbo",
                table: "Brand",
                column: "UserId",
                principalSchema: "dbo",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Card_AspNetUsers_UserId",
                schema: "dbo",
                table: "Card",
                column: "UserId",
                principalSchema: "dbo",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CardItem_AspNetUsers_UserId",
                schema: "dbo",
                table: "CardItem",
                column: "UserId",
                principalSchema: "dbo",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CardItem_Perfume_PerfumeId",
                schema: "dbo",
                table: "CardItem",
                column: "PerfumeId",
                principalSchema: "dbo",
                principalTable: "Perfume",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Perfume_AspNetUsers_UserId",
                schema: "dbo",
                table: "Perfume",
                column: "UserId",
                principalSchema: "dbo",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Perfume_Brand_BrandId",
                schema: "dbo",
                table: "Perfume",
                column: "BrandId",
                principalSchema: "dbo",
                principalTable: "Brand",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Perfume_Brand_BrandId1",
                schema: "dbo",
                table: "Perfume",
                column: "BrandId1",
                principalSchema: "dbo",
                principalTable: "Brand",
                principalColumn: "Id");
        }
    }
}
