using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyTiemChung_MVC_DOTNET.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Benhs",
                columns: table => new
                {
                    MaBenh = table.Column<string>(nullable: false),
                    TenBenh = table.Column<string>(nullable: true),
                    MoTa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benhs", x => x.MaBenh);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    MaKH = table.Column<string>(nullable: false),
                    HoTenKH = table.Column<string>(nullable: true),
                    SoDienThoai = table.Column<string>(nullable: true),
                    DiaChiKH = table.Column<string>(nullable: true),
                    NgaySinh = table.Column<DateTime>(nullable: false),
                    GioiTinh = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.MaKH);
                });

            migrationBuilder.CreateTable(
                name: "VacXins",
                columns: table => new
                {
                    MaVacXin = table.Column<string>(nullable: false),
                    TenVacXin = table.Column<string>(nullable: true),
                    SoMui = table.Column<int>(nullable: false),
                    MoTa = table.Column<string>(nullable: true),
                    TenHang = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacXins", x => x.MaVacXin);
                });

            migrationBuilder.CreateTable(
                name: "LichSuTiemPhongs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKH = table.Column<string>(nullable: true),
                    MaVacXin = table.Column<string>(nullable: true),
                    STTMui = table.Column<string>(nullable: true),
                    NgayTiemPhong = table.Column<DateTime>(nullable: false),
                    NgayHenTiepTheo = table.Column<DateTime>(nullable: false),
                    KhachHangsMaKH = table.Column<string>(nullable: true),
                    VacXinsMaVacXin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichSuTiemPhongs", x => x.id);
                    table.ForeignKey(
                        name: "FK_LichSuTiemPhongs_KhachHangs_KhachHangsMaKH",
                        column: x => x.KhachHangsMaKH,
                        principalTable: "KhachHangs",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LichSuTiemPhongs_VacXins_VacXinsMaVacXin",
                        column: x => x.VacXinsMaVacXin,
                        principalTable: "VacXins",
                        principalColumn: "MaVacXin",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhongBenhs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaVacXin = table.Column<string>(nullable: true),
                    MaBenh = table.Column<string>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true),
                    VacXinsMaVacXin = table.Column<string>(nullable: true),
                    BenhsMaBenh = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongBenhs", x => x.id);
                    table.ForeignKey(
                        name: "FK_PhongBenhs_Benhs_BenhsMaBenh",
                        column: x => x.BenhsMaBenh,
                        principalTable: "Benhs",
                        principalColumn: "MaBenh",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhongBenhs_VacXins_VacXinsMaVacXin",
                        column: x => x.VacXinsMaVacXin,
                        principalTable: "VacXins",
                        principalColumn: "MaVacXin",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LichSuTiemPhongs_KhachHangsMaKH",
                table: "LichSuTiemPhongs",
                column: "KhachHangsMaKH");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuTiemPhongs_VacXinsMaVacXin",
                table: "LichSuTiemPhongs",
                column: "VacXinsMaVacXin");

            migrationBuilder.CreateIndex(
                name: "IX_PhongBenhs_BenhsMaBenh",
                table: "PhongBenhs",
                column: "BenhsMaBenh");

            migrationBuilder.CreateIndex(
                name: "IX_PhongBenhs_VacXinsMaVacXin",
                table: "PhongBenhs",
                column: "VacXinsMaVacXin");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LichSuTiemPhongs");

            migrationBuilder.DropTable(
                name: "PhongBenhs");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "Benhs");

            migrationBuilder.DropTable(
                name: "VacXins");
        }
    }
}
