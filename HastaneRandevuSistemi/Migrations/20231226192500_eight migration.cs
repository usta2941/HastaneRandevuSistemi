using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HastaneRandevuSistemi.Migrations
{
    public partial class eightmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hastas_Doctors_DoctorId",
                table: "Hastas");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevus_Hastas_HastaId",
                table: "Randevus");

            migrationBuilder.DropIndex(
                name: "IX_Randevus_HastaId",
                table: "Randevus");

            migrationBuilder.DropIndex(
                name: "IX_Hastas_DoctorId",
                table: "Hastas");

            migrationBuilder.RenameColumn(
                name: "HastaId",
                table: "Randevus",
                newName: "HastaID");

            migrationBuilder.AddColumn<Guid>(
                name: "DoktorDoctorId",
                table: "Hastas",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Randevus_Hastas_HastaID",
                table: "Randevus",
                column: "HastaID",
                principalTable: "Hastas",
                principalColumn: "HastaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hastas_Doctors_DoktorDoctorId",
                table: "Hastas");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevus_Hastas_HastaID",
                table: "Randevus");

            migrationBuilder.DropIndex(
                name: "IX_Randevus_HastaID",
                table: "Randevus");

            migrationBuilder.DropIndex(
                name: "IX_Hastas_DoktorDoctorId",
                table: "Hastas");

            migrationBuilder.DropColumn(
                name: "DoktorDoctorId",
                table: "Hastas");

            migrationBuilder.RenameColumn(
                name: "HastaID",
                table: "Randevus",
                newName: "HastaId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevus_HastaId",
                table: "Randevus",
                column: "HastaId");

            migrationBuilder.CreateIndex(
                name: "IX_Hastas_DoctorId",
                table: "Hastas",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hastas_Doctors_DoctorId",
                table: "Hastas",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Randevus_Hastas_HastaId",
                table: "Randevus",
                column: "HastaId",
                principalTable: "Hastas",
                principalColumn: "HastaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
