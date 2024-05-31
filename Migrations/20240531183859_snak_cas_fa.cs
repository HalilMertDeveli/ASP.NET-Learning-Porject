using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetEntity.Migrations
{
    /// <inheritdoc />
    public partial class snak_cas_fa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "product_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "Products",
                newName: "Id");
        }
    }
}
