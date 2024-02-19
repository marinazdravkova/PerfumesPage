using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Product.DataLayer.Migrations
{
    public partial class changneswithuserIdinperfumes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perfume_AspNetUsers_UserId",
                schema: "dbo",
                table: "Perfume");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8295ec13-38c0-4f9d-a6ec-d21a2e8f9fef", "6d957e8a-4d7a-49ad-96a7-0c5844ffbcd5" });

            migrationBuilder.AddForeignKey(
                name: "FK_Perfume_AspNetUsers_UserId",
                schema: "dbo",
                table: "Perfume",
                column: "UserId",
                principalSchema: "dbo",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perfume_AspNetUsers_UserId",
                schema: "dbo",
                table: "Perfume");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "60f87ae1-4df1-4be5-9e7e-7a3fcb882025", "3c49da89-d00f-4246-9b7f-4efa859dad46" });

            migrationBuilder.AddForeignKey(
                name: "FK_Perfume_AspNetUsers_UserId",
                schema: "dbo",
                table: "Perfume",
                column: "UserId",
                principalSchema: "dbo",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
