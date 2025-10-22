using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthMate.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ChangeBodySiteConditionRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Conditions_BodySiteId",
                table: "Conditions");

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_BodySiteId",
                table: "Conditions",
                column: "BodySiteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Conditions_BodySiteId",
                table: "Conditions");

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_BodySiteId",
                table: "Conditions",
                column: "BodySiteId",
                unique: true,
                filter: "[BodySiteId] IS NOT NULL");
        }
    }
}
