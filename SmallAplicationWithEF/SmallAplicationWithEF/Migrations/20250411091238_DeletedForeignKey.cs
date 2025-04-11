using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmallAplicationWithEF.Migrations
{
    /// <inheritdoc />
    public partial class DeletedForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Workers_WorkersId",
                table: "Persons");

            migrationBuilder.AlterColumn<int>(
                name: "WorkersId",
                table: "Persons",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

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

            migrationBuilder.AlterColumn<int>(
                name: "WorkersId",
                table: "Persons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Workers_WorkersId",
                table: "Persons",
                column: "WorkersId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
