using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutDetails1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutDetails2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutMapLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutID);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogStatus = table.Column<bool>(type: "bit", nullable: false),
                    BlogTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogCreateDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogID);
                });

            migrationBuilder.CreateTable(
                name: "Iletisims",
                columns: table => new
                {
                    IletisimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IletisimUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IletisimMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IletisimSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IletisimMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IletisimImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IletisimCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IletisimStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iletisims", x => x.IletisimID);
                });

            migrationBuilder.CreateTable(
                name: "Psikologs",
                columns: table => new
                {
                    PsikologID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PsikologName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PsikologSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PsikologTC = table.Column<int>(type: "int", nullable: false),
                    PsikologDT = table.Column<int>(type: "int", nullable: false),
                    PsikologPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PsikologMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PsikologCinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PsikologImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PsikologAbout = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PsikologYorum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PsikologStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Psikologs", x => x.PsikologID);
                });

            migrationBuilder.CreateTable(
                name: "Randevus",
                columns: table => new
                {
                    RandevuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RandevuTarih = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RandevuStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevus", x => x.RandevuID);
                });

            migrationBuilder.CreateTable(
                name: "TelGorusmes",
                columns: table => new
                {
                    TelGorusmeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TelGorusmeTarih = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelGorusmeStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_telGorusmes", x => x.TelGorusmeID);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    TestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestStatus = table.Column<bool>(type: "bit", nullable: false),
                    TestTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestCreateDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.TestID);
                });

            migrationBuilder.CreateTable(
                name: "Uyes",
                columns: table => new
                {
                    UyeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UyeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UyeSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UyeTC = table.Column<int>(type: "int", nullable: false),
                    UyeDT = table.Column<int>(type: "int", nullable: false),
                    UyeMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UyePassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UyeCinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UyeImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UyeAbout = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UyeStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uyes", x => x.UyeID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Iletisims");

            migrationBuilder.DropTable(
                name: "Psikologs");

            migrationBuilder.DropTable(
                name: "Randevus");

            migrationBuilder.DropTable(
                name: "telGorusmes");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "Uyes");
        }
    }
}
