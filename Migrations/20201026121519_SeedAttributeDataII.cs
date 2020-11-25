using Microsoft.EntityFrameworkCore.Migrations;

namespace doublebattery.Migrations
{
    public partial class SeedAttributeDataII : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Colors (Name) VALUES ('Beige')");
            migrationBuilder.Sql("INSERT INTO Colors (Name) VALUES ('Black')");
            migrationBuilder.Sql("INSERT INTO Colors (Name) VALUES ('Blue')");
            migrationBuilder.Sql("INSERT INTO Colors (Name) VALUES ('Brown')");
            migrationBuilder.Sql("INSERT INTO Colors (Name) VALUES ('Gold')");
            migrationBuilder.Sql("INSERT INTO Colors (Name) VALUES ('Green')");
            migrationBuilder.Sql("INSERT INTO Colors (Name) VALUES ('Grey')");
            migrationBuilder.Sql("INSERT INTO Colors (Name) VALUES ('Maroon')");
            migrationBuilder.Sql("INSERT INTO Colors (Name) VALUES ('Multicolor')");
            migrationBuilder.Sql("INSERT INTO Colors (Name) VALUES ('Orange')");
            migrationBuilder.Sql("INSERT INTO Colors (Name) VALUES ('Pink')");
            migrationBuilder.Sql("INSERT INTO Colors (Name) VALUES ('Purple')");
            migrationBuilder.Sql("INSERT INTO Colors (Name) VALUES ('Red')");
            migrationBuilder.Sql("INSERT INTO Colors (Name) VALUES ('Silver')");
            migrationBuilder.Sql("INSERT INTO Colors (Name) VALUES ('Transparent')");
            migrationBuilder.Sql("INSERT INTO Colors (Name) VALUES ('White')");
            migrationBuilder.Sql("INSERT INTO Colors (Name) VALUES ('Yellow')");
            migrationBuilder.Sql("INSERT INTO FrameMaterials (Name) VALUES ('Metal')");
            migrationBuilder.Sql("INSERT INTO FrameMaterials (Name) VALUES ('Titanium')");
            migrationBuilder.Sql("INSERT INTO FrameMaterials (Name) VALUES ('Gold')");
            migrationBuilder.Sql("INSERT INTO FrameMaterials (Name) VALUES ('Silver')");
            migrationBuilder.Sql("INSERT INTO FrameMaterials (Name) VALUES ('Acetate')");
            migrationBuilder.Sql("INSERT INTO FrameMaterials (Name) VALUES ('TR90')");
            migrationBuilder.Sql("INSERT INTO FrameMaterials (Name) VALUES ('Polycarbonate')");
            migrationBuilder.Sql("INSERT INTO Styles (Name) VALUES ('Aviator')");
            migrationBuilder.Sql("INSERT INTO Styles (Name) VALUES ('Wayfarer')");
            migrationBuilder.Sql("INSERT INTO Styles (Name) VALUES ('Over Sized')");
            migrationBuilder.Sql("INSERT INTO Styles (Name) VALUES ('Wrap Around')");
            migrationBuilder.Sql("INSERT INTO Styles (Name) VALUES ('Sports')");
            migrationBuilder.Sql("INSERT INTO Styles (Name) VALUES ('Cat-eyed')");
            migrationBuilder.Sql("INSERT INTO Styles (Name) VALUES ('Oval')");
            migrationBuilder.Sql("INSERT INTO Styles (Name) VALUES ('Rectangle')");
            migrationBuilder.Sql("INSERT INTO Styles (Name) VALUES ('Round')");
            migrationBuilder.Sql("INSERT INTO Styles (Name) VALUES ('Square')");
            migrationBuilder.Sql("INSERT INTO LensColors (Name) VALUES ('Black')");
            migrationBuilder.Sql("INSERT INTO LensColors (Name) VALUES ('Blue')");
            migrationBuilder.Sql("INSERT INTO LensColors (Name) VALUES ('Brown')");
            migrationBuilder.Sql("INSERT INTO LensColors (Name) VALUES ('Clear')");
            migrationBuilder.Sql("INSERT INTO LensColors (Name) VALUES ('Golden')");
            migrationBuilder.Sql("INSERT INTO LensColors (Name) VALUES ('Green')");
            migrationBuilder.Sql("INSERT INTO LensColors (Name) VALUES ('Grey')");
            migrationBuilder.Sql("INSERT INTO LensColors (Name) VALUES ('Multicolor')");
            migrationBuilder.Sql("INSERT INTO LensColors (Name) VALUES ('Orange')");
            migrationBuilder.Sql("INSERT INTO LensColors (Name) VALUES ('Pink')");
            migrationBuilder.Sql("INSERT INTO LensColors (Name) VALUES ('Red')");
            migrationBuilder.Sql("INSERT INTO LensColors (Name) VALUES ('Silver')");
            migrationBuilder.Sql("INSERT INTO LensColors (Name) VALUES ('Violet')");
            migrationBuilder.Sql("INSERT INTO LensColors (Name) VALUES ('Yellow')");
            migrationBuilder.Sql("INSERT INTO LensColors (Name) VALUES ('Transparent')");
            migrationBuilder.Sql("INSERT INTO LensMaterials (Name) VALUES ('CR39')");
            migrationBuilder.Sql("INSERT INTO LensMaterials (Name) VALUES ('Acrylic')");
            migrationBuilder.Sql("INSERT INTO LensMaterials (Name) VALUES ('Polycarbonate')");
            migrationBuilder.Sql("INSERT INTO LensMaterials (Name) VALUES ('Glass')");





        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM LensMaterials");
            migrationBuilder.Sql("DELETE FROM LensColors");
            migrationBuilder.Sql("DELETE FROM Colors");
            migrationBuilder.Sql("DELETE FROM FrameMaterials");
            migrationBuilder.Sql("DELETE FROM Styles");

        }
    }
}
