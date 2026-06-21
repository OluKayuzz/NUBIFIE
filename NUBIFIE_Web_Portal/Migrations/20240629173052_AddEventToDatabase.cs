using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NUBIFIE_Web_Portal.Migrations
{
    /// <inheritdoc />
    public partial class AddEventToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<string>(
            //    name: "AboutUsContent",
            //    table: "SysOptions",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.AddColumn<string>(
            //    name: "HistoryContent",
            //    table: "SysOptions",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.AddColumn<string>(
            //    name: "MissionContent",
            //    table: "SysOptions",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.AddColumn<string>(
            //    name: "ObjectiveContent",
            //    table: "SysOptions",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.AddColumn<string>(
            //    name: "VissionContent",
            //    table: "SysOptions",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.AddColumn<int>(
            //    name: "NewViewFrequency",
            //    table: "News",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.AddColumn<string>(
            //    name: "NewsAudioCaption",
            //    table: "News",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.AddColumn<string>(
            //    name: "NewsCoverPicCaption",
            //    table: "News",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.AddColumn<int>(
            //    name: "NewsGroupId",
            //    table: "News",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.AddColumn<string>(
            //    name: "NewsVideoCaption",
            //    table: "News",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventCoverPicAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventDisplayPriority = table.Column<int>(type: "int", nullable: false),
                    EventCoverPicCaption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventViewFrequency = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventsPictures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    PictureVideo = table.Column<bool>(type: "bit", nullable: false),
                    PictureVideoAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    //EventVideo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureVideoCaption = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventsPictures", x => x.Id);
                });

        //    migrationBuilder.CreateTable(
        //        name: "NewsGroup",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_NewsGroup", x => x.Id);
        //        });
        //}

        ///// <inheritdoc />
        //protected override void Down(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.DropTable(
        //        name: "Events");

        //    migrationBuilder.DropTable(
        //        name: "EventsPictures");

        //    migrationBuilder.DropTable(
        //        name: "NewsGroup");

        //    migrationBuilder.DropColumn(
        //        name: "AboutUsContent",
        //        table: "SysOptions");

        //    migrationBuilder.DropColumn(
        //        name: "HistoryContent",
        //        table: "SysOptions");

        //    migrationBuilder.DropColumn(
        //        name: "MissionContent",
        //        table: "SysOptions");

        //    migrationBuilder.DropColumn(
        //        name: "ObjectiveContent",
        //        table: "SysOptions");

        //    migrationBuilder.DropColumn(
        //        name: "VissionContent",
        //        table: "SysOptions");

        //    migrationBuilder.DropColumn(
        //        name: "NewViewFrequency",
        //        table: "News");

        //    migrationBuilder.DropColumn(
        //        name: "NewsAudioCaption",
        //        table: "News");

        //    migrationBuilder.DropColumn(
        //        name: "NewsCoverPicCaption",
        //        table: "News");

        //    migrationBuilder.DropColumn(
        //        name: "NewsGroupId",
        //        table: "News");

        //    migrationBuilder.DropColumn(
        //        name: "NewsVideoCaption",
        //        table: "News");
        }
    }
}
