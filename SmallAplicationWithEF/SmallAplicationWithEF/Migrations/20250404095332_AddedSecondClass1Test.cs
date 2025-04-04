using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmallAplicationWithEF.Migrations
{
    /// <inheritdoc />
    public partial class AddedSecondClass1Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WorkersId",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Wrappers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wrappers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_WorkersId",
                table: "Items",
                column: "WorkersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Wrappers_WorkersId",
                table: "Items",
                column: "WorkersId",
                principalTable: "Wrappers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Wrappers_WorkersId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "Wrappers");

            migrationBuilder.DropIndex(
                name: "IX_Items_WorkersId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "WorkersId",
                table: "Items");
        }
    }
}
