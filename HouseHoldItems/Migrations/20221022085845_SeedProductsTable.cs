using Microsoft.EntityFrameworkCore.Migrations;

namespace HouseHoldItems.Migrations
{
    public partial class SeedProductsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Cost", "Description", "ImgUrl", "Name", "ProductCategory" },
                values: new object[,]
                {
                    { 1, 500.0, "plastic chair", null, "Plastic chair", 1 },
                    { 2, 5000.0, "Office chair", null, "Office chair", 1 },
                    { 3, 50000.0, "Laptop", null, "Hp Laptop", 0 },
                    { 4, 5000.0, "Utensils", null, "Pressure cooker", 2 },
                    { 5, 2500.0, "Cooking gas", null, "Cooking gas", 2 },
                    { 6, 3000.0, "Carpet", null, "Carpet", 3 },
                    { 7, 25000.0, "Mobile phone", null, "Samsung Galaxy", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);
        }
    }
}
