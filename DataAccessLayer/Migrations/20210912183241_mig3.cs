using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FShortDescription",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "FThumbNailImageUrl",
                table: "Foods");

            migrationBuilder.RenameColumn(
                name: "FLongDescription",
                table: "Foods",
                newName: "FDescription");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FDescription",
                table: "Foods",
                newName: "FLongDescription");

            migrationBuilder.AddColumn<string>(
                name: "FShortDescription",
                table: "Foods",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FThumbNailImageUrl",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
