using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NUBIFIE_Web_Portal.Migrations
{
    /// <inheritdoc />
    public partial class AddMemberRegistrationToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_NSS_ZCSs",
            //    table: "NSS_ZCSs");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_NACMs",
            //    table: "NACMs");

            //migrationBuilder.RenameTable(
            //    name: "NSS_ZCSs",
            //    newName: "NSS_ZCS");

            //migrationBuilder.RenameTable(
            //    name: "NACMs",
            //    newName: "NACM");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_NSS_ZCS",
            //    table: "NSS_ZCS",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_NACM",
            //    table: "NACM",
            //    column: "Id");

            migrationBuilder.CreateTable(
                name: "MemeberRegistrations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefID = table.Column<string>(type: "nvarchar(max)", nullable: false, computedColumnSql: "concat([StateID],[LGAID],right(concat('000000',[ID]),(5)))"),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "format(dateadd(hour,(1),getutcdate()),'dd/MM/yyyy')"),
                    PictureImg = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    SectorId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Othername = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false, computedColumnSql: "concat([Surname],', ',[Othername])"),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ResidentialAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LGAID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MMOId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BusinessName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminOfficeStateID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AdminOfficeLGAID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NumberOfOutlets = table.Column<int>(type: "int", nullable: true),
                    BusinessLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agreement = table.Column<bool>(type: "bit", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    EditCnt = table.Column<int>(type: "int", nullable: true),
                    DateLastEdit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Suspend = table.Column<bool>(type: "bit", nullable: false),
                    Activated = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemeberRegistrations", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemeberRegistrations");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_NSS_ZCS",
            //    table: "NSS_ZCS");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_NACM",
            //    table: "NACM");

            //migrationBuilder.RenameTable(
            //    name: "NSS_ZCS",
            //    newName: "NSS_ZCSs");

            //migrationBuilder.RenameTable(
            //    name: "NACM",
            //    newName: "NACMs");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_NSS_ZCSs",
            //    table: "NSS_ZCSs",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_NACMs",
            //    table: "NACMs",
            //    column: "Id");
        }
    }
}
