using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetEntity.Migrations
{
    /// <inheritdoc />
    public partial class ColumnMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "dbo",
                table: "Categories",
                newName: "category_name");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "dbo",
                table: "Categories",
                newName: "category_id");

            migrationBuilder.AlterColumn<string>(
                name: "category_name",
                schema: "dbo",
                table: "Categories",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "category_name",
                schema: "dbo",
                table: "Categories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "category_id",
                schema: "dbo",
                table: "Categories",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");
        }
    }
}
