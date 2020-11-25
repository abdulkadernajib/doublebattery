using Microsoft.EntityFrameworkCore.Migrations;

namespace doublebattery.Migrations
{
    public partial class SeedAttributeDataI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Shapes_ShapeId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Shapes");

            migrationBuilder.DropIndex(
                name: "IX_Products_ShapeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ShapeId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "StyleId",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Styles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Styles", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_StyleId",
                table: "Products",
                column: "StyleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Styles_StyleId",
                table: "Products",
                column: "StyleId",
                principalTable: "Styles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.Sql("INSERT INTO Categories (Name) VALUES ('EyeGlasses')");
            migrationBuilder.Sql("INSERT INTO Categories (Name) VALUES ('Sunglasses')");
            migrationBuilder.Sql("INSERT INTO Categories (Name) VALUES ('Contact Lenses')");
            migrationBuilder.Sql("INSERT INTO Categories (Name) VALUES ('Accessories')");
            migrationBuilder.Sql("INSERT INTO IdealFor (Name) VALUES ('Men')");
            migrationBuilder.Sql("INSERT INTO IdealFor (Name) VALUES ('Women')");
            migrationBuilder.Sql("INSERT INTO IdealFor (Name) VALUES ('Unisex')");
            migrationBuilder.Sql("INSERT INTO IdealFor (Name) VALUES ('Boys')");
            migrationBuilder.Sql("INSERT INTO IdealFor (Name) VALUES ('Girls')");
            migrationBuilder.Sql("INSERT INTO FrameType (Name) VALUES ('Full Rim')");
            migrationBuilder.Sql("INSERT INTO FrameType (Name) VALUES ('Half Rim')");
            migrationBuilder.Sql("INSERT INTO FrameType (Name) VALUES ('Rimless')");
            migrationBuilder.Sql("INSERT INTO Sizes (Name) VALUES ('Small')");
            migrationBuilder.Sql("INSERT INTO Sizes (Name) VALUES ('Medium')");
            migrationBuilder.Sql("INSERT INTO Sizes (Name) VALUES ('Large')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Styles_StyleId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Styles");

            migrationBuilder.DropIndex(
                name: "IX_Products_StyleId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "StyleId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ShapeId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Shapes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shapes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ShapeId",
                table: "Products",
                column: "ShapeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Shapes_ShapeId",
                table: "Products",
                column: "ShapeId",
                principalTable: "Shapes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.Sql("DELETE FROM Categories");
            migrationBuilder.Sql("DELETE FROM IdealFor");
            migrationBuilder.Sql("DELETE FROM FrameType");
            migrationBuilder.Sql("DELETE FROM Sizes");

        }
    }
}
