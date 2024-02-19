using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Product.DataLayer.Migrations
{
    public partial class changesagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardItem_Card_CardId",
                schema: "dbo",
                table: "CardItem");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_CardItem_Card_CardId1",
            //    schema: "dbo",
            //    table: "CardItem");

            //migrationBuilder.DropIndex(
            //    name: "IX_CardItem_CardId1",
            //    schema: "dbo",
            //    table: "CardItem");

            //migrationBuilder.DropColumn(
            //    name: "CardId1",
            //    schema: "dbo",
            //    table: "CardItem");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7b1fb21a-5348-4051-8f62-f40a8042524e", "80f9f5ba-00bc-4a69-a505-1ea087deac7e" });

            migrationBuilder.AddForeignKey(
                name: "FK_CardItem_Card_CardId",
                schema: "dbo",
                table: "CardItem",
                column: "CardId",
                principalSchema: "dbo",
                principalTable: "Card",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardItem_Card_CardId",
                schema: "dbo",
                table: "CardItem");

            migrationBuilder.AddColumn<Guid>(
                name: "CardId1",
                schema: "dbo",
                table: "CardItem",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fb0e80c8-cb31-43f3-b034-eb0e93ffcd49", "4983f301-75d1-40e7-b8ff-2803bf5e7781" });

            migrationBuilder.CreateIndex(
                name: "IX_CardItem_CardId1",
                schema: "dbo",
                table: "CardItem",
                column: "CardId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CardItem_Card_CardId",
                schema: "dbo",
                table: "CardItem",
                column: "CardId",
                principalSchema: "dbo",
                principalTable: "Card",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CardItem_Card_CardId1",
                schema: "dbo",
                table: "CardItem",
                column: "CardId1",
                principalSchema: "dbo",
                principalTable: "Card",
                principalColumn: "Id");
        }
    }
}
