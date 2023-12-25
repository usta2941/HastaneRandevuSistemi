using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HastaneRandevuSistemi.Migrations
{
    public partial class sevenMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevus_Doctors_DoctorId",
                table: "Randevus");

            migrationBuilder.DropIndex(
                name: "IX_Randevus_DoctorId",
                table: "Randevus");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Randevus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DoctorId",
                table: "Randevus",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Randevus_DoctorId",
                table: "Randevus",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevus_Doctors_DoctorId",
                table: "Randevus",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
