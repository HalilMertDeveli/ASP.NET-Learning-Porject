using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetEntity.Migrations
{
    /// <inheritdoc />
    public partial class snak_cas_fa1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "product_price");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "product_price",
                table: "Products",
                newName: "Price");
        }
    }
}
