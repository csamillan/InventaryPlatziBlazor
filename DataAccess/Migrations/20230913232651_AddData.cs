using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "ASH", "Aseos Hogar" },
                    { "CA1", "Categoria 1" },
                    { "CA2", "Categoria 2" }
                });

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WareHouseId", "WareHouseAddress", "WareHouseName" },
                values: new object[,]
                {
                    { "59bbda8d-248c-4946-abe0-09b2dc42ba35", "Calle B", "Bodega Primaria" },
                    { "71377a79-80eb-4330-a09a-2bff334c3086", "Calle A", "Bodega Central" },
                    { "cfcd5206-8608-4776-ad8c-f120fd1b4325", "Calle C", "Bodega Secundaria" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "ASH");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "CA1");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "CA2");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: "59bbda8d-248c-4946-abe0-09b2dc42ba35");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: "71377a79-80eb-4330-a09a-2bff334c3086");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: "cfcd5206-8608-4776-ad8c-f120fd1b4325");
        }
    }
}
