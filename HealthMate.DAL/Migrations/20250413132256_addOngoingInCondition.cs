using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthMate.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addOngoingInCondition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "Conditions",
                newName: "isOngoing");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isOngoing",
                table: "Conditions",
                newName: "isDeleted");
        }
    }
}
