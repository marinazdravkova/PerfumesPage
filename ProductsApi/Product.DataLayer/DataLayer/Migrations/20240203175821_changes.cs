using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Product.DataLayer.Migrations
{
    public partial class changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fb0e80c8-cb31-43f3-b034-eb0e93ffcd49", "4983f301-75d1-40e7-b8ff-2803bf5e7781" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d7b800d8-aca1-42c7-aa35-5dd101867506", "abe82e39-5404-4e26-a4d5-0828335d673d" });
        }
    }
}
