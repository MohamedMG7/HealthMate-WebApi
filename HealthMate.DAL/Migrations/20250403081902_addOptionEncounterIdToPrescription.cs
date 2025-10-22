using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthMate.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addOptionEncounterIdToPrescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EncounterId",
                table: "Prescriptions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeRecorded",
                table: "MedicalImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_EncounterId",
                table: "Prescriptions",
                column: "EncounterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Encoutners_EncounterId",
                table: "Prescriptions",
                column: "EncounterId",
                principalTable: "Encoutners",
                principalColumn: "Encounter_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Encoutners_EncounterId",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Prescriptions_EncounterId",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "EncounterId",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "TimeRecorded",
                table: "MedicalImages");
        }
    }
}
