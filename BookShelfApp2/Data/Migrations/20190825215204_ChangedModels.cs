using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShelfApp2.Data.Migrations
{
    public partial class ChangedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_AspNetUsers_ApplicationUserId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_ApplicationUserId",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "author",
                newName: "ApplicationUserId");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "Books",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "Books",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "author",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_ApplicationUserId1",
                table: "Books",
                column: "ApplicationUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_author_ApplicationUserId1",
                table: "author",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_author_AspNetUsers_ApplicationUserId1",
                table: "author",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_AspNetUsers_ApplicationUserId1",
                table: "Books",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_author_AspNetUsers_ApplicationUserId1",
                table: "author");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_AspNetUsers_ApplicationUserId1",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_ApplicationUserId1",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_author_ApplicationUserId1",
                table: "author");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "author");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "author",
                newName: "AppUserId");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Books",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Books_ApplicationUserId",
                table: "Books",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_AspNetUsers_ApplicationUserId",
                table: "Books",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
