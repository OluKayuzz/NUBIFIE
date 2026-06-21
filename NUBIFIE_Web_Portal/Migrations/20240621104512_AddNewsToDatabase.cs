using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NUBIFIE_Web_Portal.Models;

#nullable disable

namespace NUBIFIE_Web_Portal.Migrations
{
    /// <inheritdoc />
    public partial class AddNewsToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsCoverPicAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsHasVideo = table.Column<bool>(type: "bit", nullable: false),
                    NewsHasAudio = table.Column<bool>(type: "bit", nullable: false),
                    NewsVideoAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsAudioAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NewsSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsSourceImgAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsDisplayPriority = table.Column<int>(type: "int", nullable: false),
                    NewsGroupId=table.Column<int>(type: "int", nullable: false),
                    NewsCoverPicCaption=table.Column<string>(type: "nvarchar(max)", nullable:false),
                    NewsVideoCaption=table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsAudioCaption=table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsViewFrequency=table.Column<int>(type:"int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");
        }
    }
}
