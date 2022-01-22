using Microsoft.EntityFrameworkCore.Migrations;

namespace MySecuredApp.Migrations
{
    public partial class newnme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MyUsers",
                table: "MyUsers");

            migrationBuilder.RenameTable(
                name: "MyUsers",
                newName: "MyUser_tbl");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyUser_tbl",
                table: "MyUser_tbl",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MyUser_tbl",
                table: "MyUser_tbl");

            migrationBuilder.RenameTable(
                name: "MyUser_tbl",
                newName: "MyUsers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyUsers",
                table: "MyUsers",
                column: "Id");
        }
    }
}
