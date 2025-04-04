using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmallAplicationWithEF.Migrations
{
    /// <inheritdoc />
    public partial class ItemsChangedToPersons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Workers_WorkersId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Persons");

            migrationBuilder.RenameIndex(
                name: "IX_Items_WorkersId",
                table: "Persons",
                newName: "IX_Persons_WorkersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Workers_WorkersId",
                table: "Persons",
                column: "WorkersId",
                principalTable: "Workers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Workers_WorkersId",
                table: "Persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "Items");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_WorkersId",
                table: "Items",
                newName: "IX_Items_WorkersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Workers_WorkersId",
                table: "Items",
                column: "WorkersId",
                principalTable: "Workers",
                principalColumn: "Id");
        }
    }
}
