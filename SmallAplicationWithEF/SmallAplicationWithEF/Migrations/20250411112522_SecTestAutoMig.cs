using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmallAplicationWithEF.Migrations
{
    /// <inheritdoc />
    public partial class SecTestAutoMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Persons");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "Persons",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
