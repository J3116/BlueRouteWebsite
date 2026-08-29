using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BluelineWebsite.Migrations
{
    /// <inheritdoc />
    public partial class AddIsProcessedToContactInquiry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsProcessed",
                table: "ContactInquiries",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsProcessed",
                table: "ContactInquiries");
        }
    }
}
