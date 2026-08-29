using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BluelineWebsite.Migrations
{
    /// <inheritdoc />
    public partial class AddArabicFieldsToService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Services",
                newName: "TitleEn");

            migrationBuilder.RenameColumn(
                name: "ShortDescription",
                table: "Services",
                newName: "ShortDescriptionEn");

            migrationBuilder.RenameColumn(
                name: "FullDescription",
                table: "Services",
                newName: "FullDescriptionEn");

            migrationBuilder.AddColumn<string>(
                name: "FullDescriptionAr",
                table: "Services",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShortDescriptionAr",
                table: "Services",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TitleAr",
                table: "Services",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullDescriptionAr",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "ShortDescriptionAr",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "TitleAr",
                table: "Services");

            migrationBuilder.RenameColumn(
                name: "TitleEn",
                table: "Services",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "ShortDescriptionEn",
                table: "Services",
                newName: "ShortDescription");

            migrationBuilder.RenameColumn(
                name: "FullDescriptionEn",
                table: "Services",
                newName: "FullDescription");
        }
    }
}
