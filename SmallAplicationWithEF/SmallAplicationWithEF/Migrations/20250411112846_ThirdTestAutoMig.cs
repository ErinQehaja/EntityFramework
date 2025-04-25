using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmallAplicationWithEF.Migrations
{
    /// <inheritdoc />
    public partial class ThirdTestAutoMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Persons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Persons");
        }
    }
}
