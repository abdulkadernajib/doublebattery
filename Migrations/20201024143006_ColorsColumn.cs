using Microsoft.EntityFrameworkCore.Migrations;

namespace doublebattery.Migrations
{
    public partial class ColorsColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FrameColorId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TempleColorId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_FrameColorId",
                table: "Products",
                column: "FrameColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Colors_FrameColorId",
                table: "Products",
                column: "FrameColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.CreateIndex(
                name: "IX_Products_TempleColorId",
                table: "Products",
                column: "TempleColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Colors_TempleColorId",
                table: "Products",
                column: "TempleColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Colors_FrameColorId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Colors_TempleColorId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropIndex(
                name: "IX_Products_FrameColorId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_TempleColorId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "FrameColorId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TempleColorId",
                table: "Products");
        }
    }
}
