using Microsoft.EntityFrameworkCore.Migrations;

namespace doublebattery.Migrations
{
    public partial class UpdateColorandSizeChildIdTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SizeChildId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ColorChildId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SizeChildId",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "ColorChildId",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
