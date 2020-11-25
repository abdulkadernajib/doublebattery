using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace doublebattery.Migrations
{
    public partial class AddingDateTimeToProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdate",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Products_TempleMaterialId",
                table: "Products",
                column: "TempleMaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_FrameMaterials_TempleMaterialId",
                table: "Products",
                column: "TempleMaterialId",
                principalTable: "FrameMaterials",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastUpdate",
                table: "Products");
        }
    }
}
