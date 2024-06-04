using Microsoft.EntityFrameworkCore.Migrations;

namespace NoteBook.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblGirises",
                columns: table => new
                {
                    GirisID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblGirises", x => x.GirisID);
                });

            migrationBuilder.CreateTable(
                name: "tblNotlars",
                columns: table => new
                {
                    NotID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblNotlars", x => x.NotID);
                });

            migrationBuilder.CreateTable(
                name: "tblSifrelers",
                columns: table => new
                {
                    SifreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SifreText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSifrelers", x => x.SifreId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblGirises");

            migrationBuilder.DropTable(
                name: "tblNotlars");

            migrationBuilder.DropTable(
                name: "tblSifrelers");
        }
    }
}
