using Microsoft.EntityFrameworkCore.Migrations;

namespace doublebattery.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Brands (Name,BrandId) VALUES ('Double','DB')");
            migrationBuilder.Sql("INSERT INTO Brands (Name,BrandId) VALUES ('RayBan','RB')");
            migrationBuilder.Sql("INSERT INTO Brands (Name,BrandId) VALUES ('Vogue','VG')");
            migrationBuilder.Sql("INSERT INTO Brands (Name,BrandId) VALUES ('Police','PO')");
            migrationBuilder.Sql("INSERT INTO Brands (Name,BrandId) VALUES ('Oakley','OK')");
            migrationBuilder.Sql("INSERT INTO Models (BrandModelName,BrandId,ModelId) VALUES ('abc',1,'001')");
            migrationBuilder.Sql("INSERT INTO Models (BrandModelName,BrandId,ModelId) VALUES ('jkl',1,'002')");
            migrationBuilder.Sql("INSERT INTO Models (BrandModelName,BrandId,ModelId) VALUES ('def',1,'003')");
            migrationBuilder.Sql("INSERT INTO Models (BrandModelName,BrandId,ModelId) VALUES ('ghi',1,'004')");
            migrationBuilder.Sql("INSERT INTO Models (BrandModelName,BrandId,ModelId) VALUES ('abc',2,'001')");
            migrationBuilder.Sql("INSERT INTO Models (BrandModelName,BrandId,ModelId) VALUES ('jkl',2,'002')");
            migrationBuilder.Sql("INSERT INTO Models (BrandModelName,BrandId,ModelId) VALUES ('def',5,'003')");
            migrationBuilder.Sql("INSERT INTO Models (BrandModelName,BrandId,ModelId) VALUES ('ghi',2,'004')");
            migrationBuilder.Sql("INSERT INTO Models (BrandModelName,BrandId,ModelId) VALUES ('abc',3,'001')");
            migrationBuilder.Sql("INSERT INTO Models (BrandModelName,BrandId,ModelId) VALUES ('jkl',3,'002')");
            migrationBuilder.Sql("INSERT INTO Models (BrandModelName,BrandId,ModelId) VALUES ('def',3,'003')");
            migrationBuilder.Sql("INSERT INTO Models (BrandModelName,BrandId,ModelId) VALUES ('ghi',4,'004')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Brands");

        }
    }
}
