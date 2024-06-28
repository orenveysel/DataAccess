using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _8_CodeFirstTelefonRehberi.Migrations
{
    /// <inheritdoc />
    public partial class DeleteRuleNoAction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emails_Kisiler_KisiId",
                table: "Emails");

            migrationBuilder.AlterColumn<string>(
                name: "Ulke",
                table: "Adresler",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Sehir",
                table: "Adresler",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Ilce",
                table: "Adresler",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "CaddeSokak",
                table: "Adresler",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_Kisiler_KisiId",
                table: "Emails",
                column: "KisiId",
                principalTable: "Kisiler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emails_Kisiler_KisiId",
                table: "Emails");

            migrationBuilder.AlterColumn<string>(
                name: "Ulke",
                table: "Adresler",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Sehir",
                table: "Adresler",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ilce",
                table: "Adresler",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CaddeSokak",
                table: "Adresler",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_Kisiler_KisiId",
                table: "Emails",
                column: "KisiId",
                principalTable: "Kisiler",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
