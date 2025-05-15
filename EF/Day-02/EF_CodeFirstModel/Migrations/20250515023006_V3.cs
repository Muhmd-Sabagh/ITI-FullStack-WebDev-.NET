using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_CodeFirstModel.Migrations
{
    /// <inheritdoc />
    public partial class V3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Authors_Auth_Id",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Categories_Cat_Id",
                table: "News");

            migrationBuilder.AlterColumn<int>(
                name: "Cat_Id",
                table: "News",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Auth_Id",
                table: "News",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_News_Authors_Auth_Id",
                table: "News",
                column: "Auth_Id",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_News_Categories_Cat_Id",
                table: "News",
                column: "Cat_Id",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Authors_Auth_Id",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Categories_Cat_Id",
                table: "News");

            migrationBuilder.AlterColumn<int>(
                name: "Cat_Id",
                table: "News",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Auth_Id",
                table: "News",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Authors_Auth_Id",
                table: "News",
                column: "Auth_Id",
                principalTable: "Authors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Categories_Cat_Id",
                table: "News",
                column: "Cat_Id",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
