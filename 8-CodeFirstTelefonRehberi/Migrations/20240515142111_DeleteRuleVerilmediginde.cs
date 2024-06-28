using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _8_CodeFirstTelefonRehberi.Migrations
{
    /// <inheritdoc />
    public partial class DeleteRuleVerilmediginde : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefonlar_Kisiler_KisiId",
                table: "Telefonlar");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefonlar_Kisiler_KisiId",
                table: "Telefonlar",
                column: "KisiId",
                principalTable: "Kisiler",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefonlar_Kisiler_KisiId",
                table: "Telefonlar");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefonlar_Kisiler_KisiId",
                table: "Telefonlar",
                column: "KisiId",
                principalTable: "Kisiler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
