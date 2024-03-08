using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Khata.DAL.Migrations
{
    /// <inheritdoc />
    public partial class change_tn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Source",
                schema: "khata",
                table: "Income",
                newName: "Detail");

            migrationBuilder.RenameColumn(
                name: "Source",
                schema: "khata",
                table: "Expenditure",
                newName: "Detail");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Detail",
                schema: "khata",
                table: "Income",
                newName: "Source");

            migrationBuilder.RenameColumn(
                name: "Detail",
                schema: "khata",
                table: "Expenditure",
                newName: "Source");
        }
    }
}
