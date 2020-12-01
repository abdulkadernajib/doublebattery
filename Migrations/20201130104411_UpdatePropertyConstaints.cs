using Microsoft.EntityFrameworkCore.Migrations;

namespace doublebattery.Migrations
{
    public partial class UpdatePropertyConstaints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_FrameType_FrameTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_LensColors_LensColorId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_LensMaterials_LensMaterialId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sizes_SizeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Styles_StyleId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "StyleId",
                table: "Products",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SizeId",
                table: "Products",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LensMaterialId",
                table: "Products",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LensColorId",
                table: "Products",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FrameTypeId",
                table: "Products",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_FrameType_FrameTypeId",
                table: "Products",
                column: "FrameTypeId",
                principalTable: "FrameType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_LensColors_LensColorId",
                table: "Products",
                column: "LensColorId",
                principalTable: "LensColors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_LensMaterials_LensMaterialId",
                table: "Products",
                column: "LensMaterialId",
                principalTable: "LensMaterials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sizes_SizeId",
                table: "Products",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Styles_StyleId",
                table: "Products",
                column: "StyleId",
                principalTable: "Styles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_FrameType_FrameTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_LensColors_LensColorId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_LensMaterials_LensMaterialId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sizes_SizeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Styles_StyleId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "StyleId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SizeId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "LensMaterialId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "LensColorId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "FrameTypeId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Products_FrameType_FrameTypeId",
                table: "Products",
                column: "FrameTypeId",
                principalTable: "FrameType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_LensColors_LensColorId",
                table: "Products",
                column: "LensColorId",
                principalTable: "LensColors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_LensMaterials_LensMaterialId",
                table: "Products",
                column: "LensMaterialId",
                principalTable: "LensMaterials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sizes_SizeId",
                table: "Products",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Styles_StyleId",
                table: "Products",
                column: "StyleId",
                principalTable: "Styles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
