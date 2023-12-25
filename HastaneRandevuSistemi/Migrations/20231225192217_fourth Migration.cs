using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HastaneRandevuSistemi.Migrations
{
    public partial class fourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hastas",
                columns: table => new
                {
                    HastaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DoktorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hastas", x => x.HastaId);
                    table.ForeignKey(
                        name: "FK_Hastas_Doctors_DoktorId",
                        column: x => x.DoktorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Randevus",
                columns: table => new
                {
                    RandevuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HastaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoktorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevus", x => x.RandevuId);
                    table.ForeignKey(
                        name: "FK_Randevus_Doctors_DoktorId",
                        column: x => x.DoktorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Randevus_Hastas_HastaId",
                        column: x => x.HastaId,
                        principalTable: "Hastas",
                        principalColumn: "HastaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hastas_DoktorId",
                table: "Hastas",
                column: "DoktorId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevus_DoktorId",
                table: "Randevus",
                column: "DoktorId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevus_HastaId",
                table: "Randevus",
                column: "HastaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Randevus");

            migrationBuilder.DropTable(
                name: "Hastas");
        }
    }
}
