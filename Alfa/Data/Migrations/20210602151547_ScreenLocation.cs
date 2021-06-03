using Microsoft.EntityFrameworkCore.Migrations;

namespace Alfa.Data.Migrations
{
    public partial class ScreenLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScreenLocation",
                columns: table => new
                {
                    SerialNumber = table.Column<string>(maxLength: 12, nullable: false),
                    MyScreemId = table.Column<int>(nullable: true),
                    MyLocationID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScreenLocation", x => x.SerialNumber);
                    table.ForeignKey(
                        name: "FK_ScreenLocation_Location_MyLocationID",
                        column: x => x.MyLocationID,
                        principalTable: "Location",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScreenLocation_Screen_MyScreemId",
                        column: x => x.MyScreemId,
                        principalTable: "Screen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScreenLocation_MyLocationID",
                table: "ScreenLocation",
                column: "MyLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_ScreenLocation_MyScreemId",
                table: "ScreenLocation",
                column: "MyScreemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScreenLocation");
        }
    }
}
