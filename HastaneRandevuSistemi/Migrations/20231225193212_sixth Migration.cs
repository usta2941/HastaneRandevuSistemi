using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HastaneRandevuSistemi.Migrations
{
    public partial class sixthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hastas_Doctors_DoktorId",
                table: "Hastas");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevus_Doctors_DoktorId",
                table: "Randevus");

            migrationBuilder.RenameColumn(
                name: "DoktorId",
                table: "Randevus",
                newName: "DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_Randevus_DoktorId",
                table: "Randevus",
                newName: "IX_Randevus_DoctorId");

            migrationBuilder.RenameColumn(
                name: "DoktorId",
                table: "Hastas",
                newName: "DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_Hastas_DoktorId",
                table: "Hastas",
                newName: "IX_Hastas_DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hastas_Doctors_DoctorId",
                table: "Hastas",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Randevus_Doctors_DoctorId",
                table: "Randevus",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hastas_Doctors_DoctorId",
                table: "Hastas");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevus_Doctors_DoctorId",
                table: "Randevus");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "Randevus",
                newName: "DoktorId");

            migrationBuilder.RenameIndex(
                name: "IX_Randevus_DoctorId",
                table: "Randevus",
                newName: "IX_Randevus_DoktorId");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "Hastas",
                newName: "DoktorId");

            migrationBuilder.RenameIndex(
                name: "IX_Hastas_DoctorId",
                table: "Hastas",
                newName: "IX_Hastas_DoktorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hastas_Doctors_DoktorId",
                table: "Hastas",
                column: "DoktorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Randevus_Doctors_DoktorId",
                table: "Randevus",
                column: "DoktorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
