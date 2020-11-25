using Microsoft.EntityFrameworkCore.Migrations;

namespace doublebattery.Migrations
{
    public partial class ColorSizeVaritionAndData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Products set SizeId = 1 WHERE SizeId IS null");
            migrationBuilder.Sql("UPDATE Products set SizeVariationName = 'abc' WHERE SizeVariationName IS null");
            migrationBuilder.Sql("UPDATE Products set LensMaterialId = 1 WHERE LensMaterialId IS null");
            migrationBuilder.Sql("UPDATE Products set LensColorId = 1 WHERE LensColorId IS null");
            migrationBuilder.Sql("UPDATE Products set IdealForId = 8 WHERE IdealForId IS null");
            migrationBuilder.Sql("UPDATE Products set ColorVariationName = 'abc' WHERE ColorVariationName IS null");
            migrationBuilder.Sql("UPDATE Products set CategoryId = 5 WHERE CategoryId IS null");
            migrationBuilder.Sql("UPDATE Products set BrandSizeName = 'abd' WHERE BrandSizeName IS null");
            migrationBuilder.Sql("UPDATE Products set BrandColorName = 'abc' WHERE BrandColorName IS null");
            migrationBuilder.Sql("UPDATE Products set FrameTypeId = 1 WHERE FrameTypeId IS null");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_FrameType_FrameTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_IdealFor_IdealForId",
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
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SizeVariationName",
                table: "Products",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SizeId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LensMaterialId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LensColorId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdealForId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FrameTypeId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ColorVariationName",
                table: "Products",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BrandSizeName",
                table: "Products",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BrandColorName",
                table: "Products",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ColorVariationId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SizeVariationId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ColorVariations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorVariations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SizeVariations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SizeVariations", x => x.Id);
                });

            // migrationBuilder.CreateIndex(
            //     name: "IX_Products_ColorVariationId",
            //     table: "Products",
            //     column: "ColorVariationId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Products_SizeVariationId",
            //     table: "Products",
            //     column: "SizeVariationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            // migrationBuilder.AddForeignKey(
            //     name: "FK_Products_ColorVariations_ColorVariationId",
            //     table: "Products",
            //     column: "ColorVariationId",
            //     principalTable: "ColorVariations",
            //     principalColumn: "Id",
            //     onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_FrameType_FrameTypeId",
                table: "Products",
                column: "FrameTypeId",
                principalTable: "FrameType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_IdealFor_IdealForId",
                table: "Products",
                column: "IdealForId",
                principalTable: "IdealFor",
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

            // migrationBuilder.AddForeignKey(
            //     name: "FK_Products_SizeVariations_SizeVariationId",
            //     table: "Products",
            //     column: "SizeVariationId", 
            //     principalTable: "SizeVariations",
            //     principalColumn: "Id",
            //     onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Styles_StyleId",
                table: "Products",
                column: "StyleId",
                principalTable: "Styles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);


            migrationBuilder.Sql("INSERT INTO ColorVariations (Name) VALUES ('A')");
            migrationBuilder.Sql("INSERT INTO ColorVariations (Name) VALUES ('B')");
            migrationBuilder.Sql("INSERT INTO ColorVariations (Name) VALUES ('C')");
            migrationBuilder.Sql("INSERT INTO ColorVariations (Name) VALUES ('D')");
            migrationBuilder.Sql("INSERT INTO ColorVariations (Name) VALUES ('E')");
            migrationBuilder.Sql("INSERT INTO ColorVariations (Name) VALUES ('F')");
            migrationBuilder.Sql("INSERT INTO ColorVariations (Name) VALUES ('G')");
            migrationBuilder.Sql("INSERT INTO ColorVariations (Name) VALUES ('H')");
            migrationBuilder.Sql("INSERT INTO ColorVariations (Name) VALUES ('I')");
            migrationBuilder.Sql("INSERT INTO ColorVariations (Name) VALUES ('J')");
            migrationBuilder.Sql("INSERT INTO ColorVariations (Name) VALUES ('K')");
            migrationBuilder.Sql("INSERT INTO ColorVariations (Name) VALUES ('L')");
            migrationBuilder.Sql("INSERT INTO ColorVariations (Name) VALUES ('M')");
            migrationBuilder.Sql("INSERT INTO ColorVariations (Name) VALUES ('N')");
            migrationBuilder.Sql("INSERT INTO ColorVariations (Name) VALUES ('O')");
            migrationBuilder.Sql("INSERT INTO ColorVariations (Name) VALUES ('P')");
            migrationBuilder.Sql("INSERT INTO ColorVariations (Name) VALUES ('Q')");
            migrationBuilder.Sql("INSERT INTO ColorVariations (Name) VALUES ('R')");
            migrationBuilder.Sql("INSERT INTO ColorVariations (Name) VALUES ('S')");
            migrationBuilder.Sql("INSERT INTO ColorVariations (Name) VALUES ('T')");
            migrationBuilder.Sql("INSERT INTO ColorVariations (Name) VALUES ('U')");
            migrationBuilder.Sql("INSERT INTO ColorVariations (Name) VALUES ('V')");
            migrationBuilder.Sql("INSERT INTO ColorVariations (Name) VALUES ('W')");
            migrationBuilder.Sql("INSERT INTO ColorVariations (Name) VALUES ('X')");
            migrationBuilder.Sql("INSERT INTO ColorVariations (Name) VALUES ('Y')");
            migrationBuilder.Sql("INSERT INTO ColorVariations (Name) VALUES ('Z')");
            // migrationBuilder.Sql("UPDATE Products set ColorVariationId = 1 WHERE ColorVariationId IS null");
            migrationBuilder.Sql("INSERT INTO SizeVariations (Name) VALUES ('1')");
            migrationBuilder.Sql("INSERT INTO SizeVariations (Name) VALUES ('2')");
            migrationBuilder.Sql("INSERT INTO SizeVariations (Name) VALUES ('3')");
            migrationBuilder.Sql("INSERT INTO SizeVariations (Name) VALUES ('4')");
            migrationBuilder.Sql("INSERT INTO SizeVariations (Name) VALUES ('5')");
            migrationBuilder.Sql("INSERT INTO SizeVariations (Name) VALUES ('6')");
            migrationBuilder.Sql("INSERT INTO SizeVariations (Name) VALUES ('7')");
            migrationBuilder.Sql("INSERT INTO SizeVariations (Name) VALUES ('8')");
            migrationBuilder.Sql("INSERT INTO SizeVariations (Name) VALUES ('9')");
            migrationBuilder.Sql("INSERT INTO SizeVariations (Name) VALUES ('0')");
            // migrationBuilder.Sql("UPDATE Products set SizeVariationId = 1 WHERE SizeVariationId IS null");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ColorVariations_ColorVariationId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_FrameType_FrameTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_IdealFor_IdealForId",
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
                name: "FK_Products_SizeVariations_SizeVariationId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Styles_StyleId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ColorVariations");

            migrationBuilder.DropTable(
                name: "SizeVariations");

            migrationBuilder.DropIndex(
                name: "IX_Products_ColorVariationId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SizeVariationId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ColorVariationId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SizeVariationId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "StyleId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "SizeVariationName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

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
                name: "IdealForId",
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

            migrationBuilder.AlterColumn<string>(
                name: "ColorVariationName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "BrandSizeName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "BrandColorName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_FrameType_FrameTypeId",
                table: "Products",
                column: "FrameTypeId",
                principalTable: "FrameType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_IdealFor_IdealForId",
                table: "Products",
                column: "IdealForId",
                principalTable: "IdealFor",
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
