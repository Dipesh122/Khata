using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Khata.DAL.Migrations
{
    /// <inheritdoc />
    public partial class change_fn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Person",
                schema: "khata",
                table: "Income",
                newName: "GenerateBy");

            migrationBuilder.RenameColumn(
                name: "Person",
                schema: "khata",
                table: "Expenditure",
                newName: "SpendBy");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenerateBy",
                schema: "khata",
                table: "Income",
                newName: "Person");

            migrationBuilder.RenameColumn(
                name: "SpendBy",
                schema: "khata",
                table: "Expenditure",
                newName: "Person");
        }
    }
}
