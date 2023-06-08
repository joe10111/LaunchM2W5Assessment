using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace M2W5Assessment.Migrations
{
    public partial class FixedDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_concert_performer_performer_performers_id",
                table: "concert_performer");

            migrationBuilder.DropTable(
                name: "performer");

            migrationBuilder.CreateTable(
                name: "performers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    act_description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_performers", x => x.id);
                });

            migrationBuilder.AddForeignKey(
                name: "fk_concert_performer_performers_performers_id",
                table: "concert_performer",
                column: "performers_id",
                principalTable: "performers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_concert_performer_performers_performers_id",
                table: "concert_performer");

            migrationBuilder.DropTable(
                name: "performers");

            migrationBuilder.CreateTable(
                name: "performer",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    act_description = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_performer", x => x.id);
                });

            migrationBuilder.AddForeignKey(
                name: "fk_concert_performer_performer_performers_id",
                table: "concert_performer",
                column: "performers_id",
                principalTable: "performer",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
