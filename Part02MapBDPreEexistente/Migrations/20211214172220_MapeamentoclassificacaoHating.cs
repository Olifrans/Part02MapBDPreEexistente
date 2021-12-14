using Microsoft.EntityFrameworkCore.Migrations;

namespace Part02MapBDPreEexistente.Migrations
{
    public partial class MapeamentoclassificacaoHating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "rating",
                table: "film",
                type: "varchar(10)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rating",
                table: "film");
        }
    }
}
