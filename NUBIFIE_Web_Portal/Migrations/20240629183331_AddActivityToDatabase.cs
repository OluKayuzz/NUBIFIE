using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NUBIFIE_Web_Portal.Migrations
{
    /// <inheritdoc />
    public partial class AddActivityToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivityContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivityUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivityCoverPicAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivityDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActivityDisplayPriority = table.Column<int>(type: "int", nullable: false),
                    ActivityCoverPicCaption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivityViewFrequency = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActivityPictures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    ActivitiesPicture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureCaption = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityPictures", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "ActivityPictures");
        }
    }
}
