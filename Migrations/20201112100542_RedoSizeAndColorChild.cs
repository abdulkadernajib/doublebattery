using Microsoft.EntityFrameworkCore.Migrations;

namespace doublebattery.Migrations
{
    public partial class RedoSizeAndColorChild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
               name: "ColorChildIds",
               columns: table => new
               {
                   Id = table.Column<int>(nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   Name = table.Column<string>(maxLength: 50, nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_ColorChildIds", x => x.Id);
               });

            migrationBuilder.CreateTable(
                name: "SizeChildIds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SizeChildIds", x => x.Id);
                });

            migrationBuilder.Sql("INSERT INTO ColorChildIds (Name) VALUES ('A')");
            migrationBuilder.Sql("INSERT INTO ColorChildIds (Name) VALUES ('B')");
            migrationBuilder.Sql("INSERT INTO ColorChildIds (Name) VALUES ('C')");
            migrationBuilder.Sql("INSERT INTO ColorChildIds (Name) VALUES ('D')");
            migrationBuilder.Sql("INSERT INTO ColorChildIds (Name) VALUES ('E')");
            migrationBuilder.Sql("INSERT INTO ColorChildIds (Name) VALUES ('F')");
            migrationBuilder.Sql("INSERT INTO ColorChildIds (Name) VALUES ('G')");
            migrationBuilder.Sql("INSERT INTO ColorChildIds (Name) VALUES ('H')");
            migrationBuilder.Sql("INSERT INTO ColorChildIds (Name) VALUES ('I')");
            migrationBuilder.Sql("INSERT INTO ColorChildIds (Name) VALUES ('J')");
            migrationBuilder.Sql("INSERT INTO ColorChildIds (Name) VALUES ('K')");
            migrationBuilder.Sql("INSERT INTO ColorChildIds (Name) VALUES ('L')");
            migrationBuilder.Sql("INSERT INTO ColorChildIds (Name) VALUES ('M')");
            migrationBuilder.Sql("INSERT INTO ColorChildIds (Name) VALUES ('N')");
            migrationBuilder.Sql("INSERT INTO ColorChildIds (Name) VALUES ('O')");
            migrationBuilder.Sql("INSERT INTO ColorChildIds (Name) VALUES ('P')");
            migrationBuilder.Sql("INSERT INTO ColorChildIds (Name) VALUES ('Q')");
            migrationBuilder.Sql("INSERT INTO ColorChildIds (Name) VALUES ('R')");
            migrationBuilder.Sql("INSERT INTO ColorChildIds (Name) VALUES ('S')");
            migrationBuilder.Sql("INSERT INTO ColorChildIds (Name) VALUES ('T')");
            migrationBuilder.Sql("INSERT INTO ColorChildIds (Name) VALUES ('U')");
            migrationBuilder.Sql("INSERT INTO ColorChildIds (Name) VALUES ('V')");
            migrationBuilder.Sql("INSERT INTO ColorChildIds (Name) VALUES ('W')");
            migrationBuilder.Sql("INSERT INTO ColorChildIds (Name) VALUES ('X')");
            migrationBuilder.Sql("INSERT INTO ColorChildIds (Name) VALUES ('Y')");
            migrationBuilder.Sql("INSERT INTO ColorChildIds (Name) VALUES ('Z')");

            migrationBuilder.Sql("INSERT INTO SizeChildIds (Name) VALUES ('1')");
            migrationBuilder.Sql("INSERT INTO SizeChildIds (Name) VALUES ('2')");
            migrationBuilder.Sql("INSERT INTO SizeChildIds (Name) VALUES ('3')");
            migrationBuilder.Sql("INSERT INTO SizeChildIds (Name) VALUES ('4')");
            migrationBuilder.Sql("INSERT INTO SizeChildIds (Name) VALUES ('5')");
            migrationBuilder.Sql("INSERT INTO SizeChildIds (Name) VALUES ('6')");
            migrationBuilder.Sql("INSERT INTO SizeChildIds (Name) VALUES ('7')");
            migrationBuilder.Sql("INSERT INTO SizeChildIds (Name) VALUES ('8')");
            migrationBuilder.Sql("INSERT INTO SizeChildIds (Name) VALUES ('9')");
            migrationBuilder.Sql("INSERT INTO SizeChildIds (Name) VALUES ('0')");

            migrationBuilder.AddColumn<int>(
                name: "ColorChildId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ColorChildName",
                table: "Products",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SizeChildId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SizeChildName",
                table: "Products",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ColorChildIdId",
                table: "Products",
                column: "ColorChildId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SizeChildIdId",
                table: "Products",
                column: "SizeChildId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ColorChildIds_ColorChildIdId",
                table: "Products",
                column: "ColorChildId",
                principalTable: "ColorChildIds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SizeChildIds_SizeChildIdId",
                table: "Products",
                column: "SizeChildId",
                principalTable: "SizeChildIds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.Sql("UPDATE Products set ColorChildId = 1 WHERE ColorChildId IS null");
            migrationBuilder.Sql("UPDATE Products set SizeChildId = 1 WHERE SizeChildId IS null");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                 name: "FK_Products_ColorChildIds_ColorChildId",
                 table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_SizeChildIds_SizeChildId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ColorChildIds");

            migrationBuilder.DropTable(
                name: "SizeChildIds");

            migrationBuilder.DropIndex(
                name: "IX_Products_ColorChildId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SizeChildId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ColorChildId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ColorChildName",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SizeChildId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SizeChildName",
                table: "Products");
        }
    }
}
