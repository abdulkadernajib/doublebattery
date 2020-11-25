using Microsoft.EntityFrameworkCore.Migrations;

namespace doublebattery.Migrations
{
    public partial class AddAttributesToProductsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BrandColorName",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BrandSizeName",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ColorVariationName",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FrameMaterialId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FrameTypeId",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdealForId",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LensColorId",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LensMaterialId",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShapeId",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SizeVariationName",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TempleMaterialId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FrameMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrameMaterials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FrameType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrameType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdealFor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdealFor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LensColors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LensColors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LensMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LensMaterials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shapes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shapes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_FrameMaterialId",
                table: "Products",
                column: "FrameMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_FrameTypeId",
                table: "Products",
                column: "FrameTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_IdealForId",
                table: "Products",
                column: "IdealForId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_LensColorId",
                table: "Products",
                column: "LensColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_LensMaterialId",
                table: "Products",
                column: "LensMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ShapeId",
                table: "Products",
                column: "ShapeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SizeId",
                table: "Products",
                column: "SizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_FrameMaterials_FrameMaterialId",
                table: "Products",
                column: "FrameMaterialId",
                principalTable: "FrameMaterials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Products_Shapes_ShapeId",
                table: "Products",
                column: "ShapeId",
                principalTable: "Shapes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sizes_SizeId",
                table: "Products",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_FrameMaterials_FrameMaterialId",
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
                name: "FK_Products_Shapes_ShapeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sizes_SizeId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "FrameMaterials");

            migrationBuilder.DropTable(
                name: "FrameType");

            migrationBuilder.DropTable(
                name: "IdealFor");

            migrationBuilder.DropTable(
                name: "LensColors");

            migrationBuilder.DropTable(
                name: "LensMaterials");

            migrationBuilder.DropTable(
                name: "Shapes");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_FrameMaterialId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_FrameTypeId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_IdealForId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_LensColorId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_LensMaterialId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ShapeId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SizeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BrandColorName",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BrandSizeName",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ColorVariationName",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "FrameMaterialId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "FrameTypeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IdealForId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LensColorId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LensMaterialId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ShapeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SizeVariationName",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TempleMaterialId",
                table: "Products");
        }
    }
}
