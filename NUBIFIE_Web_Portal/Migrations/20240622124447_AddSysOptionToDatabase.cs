using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NUBIFIE_Web_Portal.Migrations
{
    /// <inheritdoc />
    public partial class AddSysOptionToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NewsDisplayPriority",
                table: "News",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SysOptions",
                columns: table => new
                {
                    RefID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmptyFrame = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    MediaFrame = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageTitle1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageTitle3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageTitle4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageTitle5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL5 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SysOptions");

            migrationBuilder.DropColumn(
                name: "NewsDisplayPriority",
                table: "News");
        }
    }
}
