using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhamThiVanAnh.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "News",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NewsID",
                table: "Comment",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_News_CategoryID",
                table: "News",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_NewsID",
                table: "Comment",
                column: "NewsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_News_NewsID",
                table: "Comment",
                column: "NewsID",
                principalTable: "News",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Category_CategoryID",
                table: "News",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_News_NewsID",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Category_CategoryID",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_CategoryID",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_Comment_NewsID",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "News");

            migrationBuilder.DropColumn(
                name: "NewsID",
                table: "Comment");
        }
    }
}
