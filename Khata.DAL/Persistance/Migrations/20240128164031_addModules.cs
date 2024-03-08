using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Khata.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addModules : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tests");

            migrationBuilder.EnsureSchema(
                name: "khata");

            migrationBuilder.CreateTable(
                name: "Expenditure",
                schema: "khata",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Source = table.Column<string>(type: "text", nullable: true),
                    Cost = table.Column<double>(type: "double precision", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: true),
                    Person = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenditure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Income",
                schema: "khata",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Source = table.Column<string>(type: "text", nullable: true),
                    Amount = table.Column<double>(type: "double precision", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: true),
                    Person = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Income", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expenditure",
                schema: "khata");

            migrationBuilder.DropTable(
                name: "Income",
                schema: "khata");

            migrationBuilder.CreateTable(
                name: "tests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tests", x => x.Id);
                });
        }
    }
}
