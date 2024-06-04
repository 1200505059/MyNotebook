using Microsoft.EntityFrameworkCore.Migrations;

namespace NoteBook.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SifreTitle",
                table: "tblSifrelers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SifreTitle",
                table: "tblSifrelers");
        }
    }
}
