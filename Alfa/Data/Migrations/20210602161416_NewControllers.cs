using Microsoft.EntityFrameworkCore.Migrations;

namespace Alfa.Data.Migrations
{
    public partial class NewControllers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScreenLocation_Location_MyLocationID",
                table: "ScreenLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_ScreenLocation_Screen_MyScreemId",
                table: "ScreenLocation");

            migrationBuilder.DropIndex(
                name: "IX_ScreenLocation_MyLocationID",
                table: "ScreenLocation");

            migrationBuilder.DropIndex(
                name: "IX_ScreenLocation_MyScreemId",
                table: "ScreenLocation");

            migrationBuilder.DropColumn(
                name: "MyLocationID",
                table: "ScreenLocation");

            migrationBuilder.DropColumn(
                name: "MyScreemId",
                table: "ScreenLocation");

            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "ScreenLocation",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ScreenId",
                table: "ScreenLocation",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ScreenLocation_LocationID",
                table: "ScreenLocation",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_ScreenLocation_ScreenId",
                table: "ScreenLocation",
                column: "ScreenId");

            migrationBuilder.AddForeignKey(
                name: "FK_ScreenLocation_Location_LocationID",
                table: "ScreenLocation",
                column: "LocationID",
                principalTable: "Location",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScreenLocation_Screen_ScreenId",
                table: "ScreenLocation",
                column: "ScreenId",
                principalTable: "Screen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScreenLocation_Location_LocationID",
                table: "ScreenLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_ScreenLocation_Screen_ScreenId",
                table: "ScreenLocation");

            migrationBuilder.DropIndex(
                name: "IX_ScreenLocation_LocationID",
                table: "ScreenLocation");

            migrationBuilder.DropIndex(
                name: "IX_ScreenLocation_ScreenId",
                table: "ScreenLocation");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "ScreenLocation");

            migrationBuilder.DropColumn(
                name: "ScreenId",
                table: "ScreenLocation");

            migrationBuilder.AddColumn<int>(
                name: "MyLocationID",
                table: "ScreenLocation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MyScreemId",
                table: "ScreenLocation",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ScreenLocation_MyLocationID",
                table: "ScreenLocation",
                column: "MyLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_ScreenLocation_MyScreemId",
                table: "ScreenLocation",
                column: "MyScreemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ScreenLocation_Location_MyLocationID",
                table: "ScreenLocation",
                column: "MyLocationID",
                principalTable: "Location",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScreenLocation_Screen_MyScreemId",
                table: "ScreenLocation",
                column: "MyScreemId",
                principalTable: "Screen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
