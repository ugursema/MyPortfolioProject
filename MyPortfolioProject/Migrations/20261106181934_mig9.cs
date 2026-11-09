using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPortfolioProject.Migrations
{
    /// <inheritdoc />
    public partial class mig9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Icon",
                table: "AboutRights",
                newName: "Description3");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "AboutRights",
                newName: "Description2");

            migrationBuilder.AddColumn<string>(
                name: "Description1",
                table: "AboutRights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description1",
                table: "AboutRights");

            migrationBuilder.RenameColumn(
                name: "Description3",
                table: "AboutRights",
                newName: "Icon");

            migrationBuilder.RenameColumn(
                name: "Description2",
                table: "AboutRights",
                newName: "Description");
        }
    }
}
