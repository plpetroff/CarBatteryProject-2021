using Microsoft.EntityFrameworkCore.Migrations;

namespace CarBatteries.Data.Migrations
{
    public partial class ImageAndBatteryCodeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Batteries_ImageId",
                table: "Batteries");

            migrationBuilder.CreateIndex(
                name: "IX_Batteries_ImageId",
                table: "Batteries",
                column: "ImageId",
                unique: true,
                filter: "[ImageId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Batteries_ImageId",
                table: "Batteries");

            migrationBuilder.CreateIndex(
                name: "IX_Batteries_ImageId",
                table: "Batteries",
                column: "ImageId");
        }
    }
}
