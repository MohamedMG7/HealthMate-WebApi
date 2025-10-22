using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthMate.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addNameIdentifierToLabTestAndObservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameIdentifier",
                table: "Observations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NameIdentifier",
                table: "LabTests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameIdentifier",
                table: "Observations");

            migrationBuilder.DropColumn(
                name: "NameIdentifier",
                table: "LabTests");
        }
    }
}
