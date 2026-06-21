using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NUBIFIE_Web_Portal.Migrations
{
    /// <inheritdoc />
    public partial class AddNACMnNSS_ZCSToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "EventVideo",
            //    table: "EventsPictures");

            //migrationBuilder.RenameColumn(
            //    name: "EventsPicture",
            //    table: "EventsPictures",
            //    newName: "PictureVideoAddress");

            //migrationBuilder.RenameColumn(
            //    name: "ActivitiesPicture",
            //    table: "ActivityPictures",
            //    newName: "ActivityPictureAddress");

            //migrationBuilder.AddColumn<string>(
            //    name: "NACM_Intro",
            //    table: "SysOptions",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.AddColumn<string>(
            //    name: "NSS_ZCS_Intro",
            //    table: "SysOptions",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    defaultValue: "");

            migrationBuilder.CreateTable(
                name: "NACMs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonPicAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OfficeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    OrderList = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NACMs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NSS_ZCSs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonPicAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OfficeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    OrderList = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NSS_ZCSs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NACMs");

            migrationBuilder.DropTable(
                name: "NSS_ZCSs");

            //migrationBuilder.DropColumn(
            //    name: "NACM_Intro",
            //    table: "SysOptions");

            //migrationBuilder.DropColumn(
            //    name: "NSS_ZCS_Intro",
            //    table: "SysOptions");

            //migrationBuilder.RenameColumn(
            //    name: "PictureVideoAddress",
            //    table: "EventsPictures",
            //    newName: "EventsPicture");

            //migrationBuilder.RenameColumn(
            //    name: "ActivityPictureAddress",
            //    table: "ActivityPictures",
            //    newName: "ActivitiesPicture");

            //migrationBuilder.AddColumn<string>(
            //    name: "EventVideo",
            //    table: "EventsPictures",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    defaultValue: "");
        }
    }
}
