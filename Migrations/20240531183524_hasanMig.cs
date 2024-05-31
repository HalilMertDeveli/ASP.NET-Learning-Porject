using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetEntity.Migrations
{
    /// <inheritdoc />
    public partial class hasanMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                schema: "dbo",
                table: "Categories");

            migrationBuilder.EnsureSchema(
                name: "c");

            migrationBuilder.RenameTable(
                name: "Categories",
                schema: "dbo",
                newName: "Category",
                newSchema: "c");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "product_name");

            migrationBuilder.AlterColumn<string>(
                name: "product_name",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                schema: "c",
                table: "Category",
                column: "category_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                schema: "c",
                table: "Category");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "Category",
                schema: "c",
                newName: "Categories",
                newSchema: "dbo");

            migrationBuilder.RenameColumn(
                name: "product_name",
                table: "Products",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                schema: "dbo",
                table: "Categories",
                column: "category_id");
        }
    }
}
