using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Product.DataLayer.Migrations
{
    public partial class changesaddeduserIdbrandMap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brand_AspNetUsers_UserId",
                schema: "dbo",
                table: "Brand");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1295ca20-3a13-4bf1-9e87-fe7441871812", "1ba26a55-834d-475e-aa74-4bd8fdac4de9" });

            migrationBuilder.AddForeignKey(
                name: "FK_Brand_AspNetUsers_UserId",
                schema: "dbo",
                table: "Brand",
                column: "UserId",
                principalSchema: "dbo",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brand_AspNetUsers_UserId",
                schema: "dbo",
                table: "Brand");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7b1fb21a-5348-4051-8f62-f40a8042524e", "80f9f5ba-00bc-4a69-a505-1ea087deac7e" });

            migrationBuilder.AddForeignKey(
                name: "FK_Brand_AspNetUsers_UserId",
                schema: "dbo",
                table: "Brand",
                column: "UserId",
                principalSchema: "dbo",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
