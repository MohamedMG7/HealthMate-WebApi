using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthMate.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addPurposeVerificationCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Purpose",
                table: "VerificationCodes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Purpose",
                table: "VerificationCodes");
        }
    }
}
