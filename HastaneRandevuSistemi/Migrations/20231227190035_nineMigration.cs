using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HastaneRandevuSistemi.Migrations
{
    public partial class nineMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hastas_Doctors_DoktorDoctorId",
                table: "Hastas");

            migrationBuilder.DropIndex(
                name: "IX_Randevus_HastaID",
                table: "Randevus");

            migrationBuilder.DropIndex(
                name: "IX_Hastas_DoktorDoctorId",
                table: "Hastas");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Hastas");

            migrationBuilder.DropColumn(
                name: "DoktorDoctorId",
                table: "Hastas");

            migrationBuilder.DropColumn(
                name: "Deparmant",
                table: "Doctors");

            migrationBuilder.AddColumn<Guid>(
                name: "DoktorId",
                table: "Randevus",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "clinicId",
                table: "Doctors",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "clinics",
                columns: table => new
                {
                    clinicId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    clinicName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clinics", x => x.clinicId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Randevus_DoktorId",
                table: "Randevus",
                column: "DoktorId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevus_HastaID",
                table: "Randevus",
                column: "HastaID");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_clinicId",
                table: "Doctors",
                column: "clinicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_clinics_clinicId",
                table: "Doctors",
                column: "clinicId",
                principalTable: "clinics",
                principalColumn: "clinicId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Randevus_Doctors_DoktorId",
                table: "Randevus",
                column: "DoktorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_clinics_clinicId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevus_Doctors_DoktorId",
                table: "Randevus");

            migrationBuilder.DropTable(
                name: "clinics");

            migrationBuilder.DropIndex(
                name: "IX_Randevus_DoktorId",
                table: "Randevus");

            migrationBuilder.DropIndex(
                name: "IX_Randevus_HastaID",
                table: "Randevus");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_clinicId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "DoktorId",
                table: "Randevus");

            migrationBuilder.DropColumn(
                name: "clinicId",
                table: "Doctors");

            migrationBuilder.AddColumn<Guid>(
                name: "DoctorId",
                table: "Hastas",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DoktorDoctorId",
                table: "Hastas",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Deparmant",
                table: "Doctors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Randevus_HastaID",
                table: "Randevus",
                column: "HastaID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hastas_DoktorDoctorId",
                table: "Hastas",
                column: "DoktorDoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hastas_Doctors_DoktorDoctorId",
                table: "Hastas",
                column: "DoktorDoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId");
        }
    }
}
