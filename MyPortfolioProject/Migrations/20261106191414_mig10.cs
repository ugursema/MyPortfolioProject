using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPortfolioProject.Migrations
{
    /// <inheritdoc />
    public partial class mig10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TechnicalSkills",
                columns: table => new
                {
                    TechnicalSkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle6 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnicalSkills", x => x.TechnicalSkillId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TechnicalSkills");
        }
    }
}
