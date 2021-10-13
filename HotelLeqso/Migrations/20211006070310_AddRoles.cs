using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelApi.Migrations
{
    public partial class AddRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "644097e9-52f9-4ddc-a421-e78c5ff8d38f", "037b819f-8a28-41c9-9e48-b3e57a8e7924", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9f785941-7eb4-480e-87a3-fb9ad4a0736d", "88f20da5-e6df-4e64-9cad-3c93dfaf84fb", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "644097e9-52f9-4ddc-a421-e78c5ff8d38f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f785941-7eb4-480e-87a3-fb9ad4a0736d");
        }
    }
}
