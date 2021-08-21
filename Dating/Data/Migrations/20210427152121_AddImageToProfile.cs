using Microsoft.EntityFrameworkCore.Migrations;

namespace Dating.Data.Migrations
{
    public partial class AddImageToProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Profiles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Profiles");
        }
    }
}
