using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_telGorusmes",
                table: "telGorusmes");

            migrationBuilder.RenameTable(
                name: "telGorusmes",
                newName: "TelGorusmes");

            migrationBuilder.AddColumn<int>(
                name: "PsikologID",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TelGorusmes",
                table: "TelGorusmes",
                column: "TelGorusmeID");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_PsikologID",
                table: "Blogs",
                column: "PsikologID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Psikologs_PsikologID",
                table: "Blogs",
                column: "PsikologID",
                principalTable: "Psikologs",
                principalColumn: "PsikologID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Psikologs_PsikologID",
                table: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TelGorusmes",
                table: "TelGorusmes");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_PsikologID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "PsikologID",
                table: "Blogs");

            migrationBuilder.RenameTable(
                name: "TelGorusmes",
                newName: "telGorusmes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_telGorusmes",
                table: "telGorusmes",
                column: "TelGorusmeID");
        }
    }
}
