using Microsoft.EntityFrameworkCore.Migrations;

namespace Proje.ToDo.DataAccess.Migrations
{
    public partial class WorkColumnsModifiedToDoContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Works",
                type: "ntext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Description",
                table: "Works",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "ntext");
        }
    }
}
