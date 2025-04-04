using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmallAplicationWithEF.Migrations
{
    /// <inheritdoc />
    public partial class AddedWorkersEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Wrappers_WorkersId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wrappers",
                table: "Wrappers");

            migrationBuilder.RenameTable(
                name: "Wrappers",
                newName: "Workers");

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Workers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Workers",
                table: "Workers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Workers_WorkersId",
                table: "Items",
                column: "WorkersId",
                principalTable: "Workers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Workers_WorkersId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Workers",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Workers");

            migrationBuilder.RenameTable(
                name: "Workers",
                newName: "Wrappers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wrappers",
                table: "Wrappers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Wrappers_WorkersId",
                table: "Items",
                column: "WorkersId",
                principalTable: "Wrappers",
                principalColumn: "Id");
        }
    }
}
