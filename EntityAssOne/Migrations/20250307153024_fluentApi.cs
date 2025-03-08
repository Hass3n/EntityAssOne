using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityAssOne.Migrations
{
    /// <inheritdoc />
    public partial class fluentApi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "favourite");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                schema: "dbo",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Cairo");

            migrationBuilder.CreateTable(
                name: "Favourites",
                schema: "favourite",
                columns: table => new
                {
                    FavId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FavouritesName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    FavDate = table.Column<DateTime>(type: "datetime2", nullable: false, computedColumnSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favourites", x => x.FavId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favourites",
                schema: "favourite");

            migrationBuilder.DropColumn(
                name: "Address",
                schema: "dbo",
                table: "Employee");
        }
    }
}
