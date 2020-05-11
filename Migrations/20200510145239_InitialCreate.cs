using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyTiemChung_MVC_DOTNET.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    username = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: true),
                    MaKH = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.username);
                    table.ForeignKey(
                        name: "FK_Users_KhachHangs_MaKH",
                        column: x => x.MaKH,
                        principalTable: "KhachHangs",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_MaKH",
                table: "Users",
                column: "MaKH",
                unique: true,
                filter: "[MaKH] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
