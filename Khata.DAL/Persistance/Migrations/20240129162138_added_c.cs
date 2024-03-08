using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Khata.DAL.Migrations
{
    /// <inheritdoc />
    public partial class added_c : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Loan",
                schema: "khata",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Amount = table.Column<double>(type: "double precision", nullable: false),
                    Method = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loan", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loan",
                schema: "khata");
        }
    }
}
