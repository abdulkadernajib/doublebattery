using Microsoft.EntityFrameworkCore.Migrations;

namespace doublebattery.Migrations
{
    public partial class DeleteDataFromModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Models");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
