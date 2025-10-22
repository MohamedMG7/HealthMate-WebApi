using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthMate.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addMedicineDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicines_Medicine_MedicineId",
                table: "PatientMedicines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicine",
                table: "Medicine");

            migrationBuilder.RenameTable(
                name: "Medicine",
                newName: "Medicines");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicines",
                table: "Medicines",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicines_Medicines_MedicineId",
                table: "PatientMedicines",
                column: "MedicineId",
                principalTable: "Medicines",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicines_Medicines_MedicineId",
                table: "PatientMedicines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicines",
                table: "Medicines");

            migrationBuilder.RenameTable(
                name: "Medicines",
                newName: "Medicine");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicine",
                table: "Medicine",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicines_Medicine_MedicineId",
                table: "PatientMedicines",
                column: "MedicineId",
                principalTable: "Medicine",
                principalColumn: "Id");
        }
    }
}
