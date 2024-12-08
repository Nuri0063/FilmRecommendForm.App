using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmRecommendForm.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.AddColumn<string>(
                name: "PosterURL",
                table: "Movies",
                type: "longchar",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PosterURL",
                table: "Movies");
        }
    }
}
