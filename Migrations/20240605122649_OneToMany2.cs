using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetEntity.Migrations
{
    /// <inheritdoc />
    public partial class OneToMany2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesHistory_Products_ProductId",
                table: "SalesHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesHistory",
                table: "SalesHistory");

            migrationBuilder.RenameTable(
                name: "SalesHistory",
                newName: "SalesHistories");

            migrationBuilder.RenameIndex(
                name: "IX_SalesHistory_ProductId",
                table: "SalesHistories",
                newName: "IX_SalesHistories_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesHistories",
                table: "SalesHistories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesHistories_Products_ProductId",
                table: "SalesHistories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesHistories_Products_ProductId",
                table: "SalesHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesHistories",
                table: "SalesHistories");

            migrationBuilder.RenameTable(
                name: "SalesHistories",
                newName: "SalesHistory");

            migrationBuilder.RenameIndex(
                name: "IX_SalesHistories_ProductId",
                table: "SalesHistory",
                newName: "IX_SalesHistory_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesHistory",
                table: "SalesHistory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesHistory_Products_ProductId",
                table: "SalesHistory",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
