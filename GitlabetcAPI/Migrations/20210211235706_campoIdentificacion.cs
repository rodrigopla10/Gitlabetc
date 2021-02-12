using Microsoft.EntityFrameworkCore.Migrations;

namespace GitlabetcAPI.Migrations
{
    public partial class campoIdentificacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "identificacion",
                table: "Cliente",
                type: "nvarchar(100)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "identificacion",
                table: "Cliente");
        }
    }
}
