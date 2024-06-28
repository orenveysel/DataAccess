using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace _7_EfCoreLabKutuphane.Migrations
{
    /// <inheritdoc />
    public partial class OduncKitap : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Yazarlar",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 15, 12, 29, 6, 256, DateTimeKind.Utc).AddTicks(4509),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 15, 12, 9, 8, 756, DateTimeKind.Utc).AddTicks(5863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Raflar",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 15, 12, 29, 6, 256, DateTimeKind.Utc).AddTicks(2500),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 15, 12, 9, 8, 756, DateTimeKind.Utc).AddTicks(3448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kitaplar",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 15, 12, 29, 6, 255, DateTimeKind.Utc).AddTicks(4868),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 15, 12, 9, 8, 755, DateTimeKind.Utc).AddTicks(8400));

            migrationBuilder.CreateTable(
                name: "Uye",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AdSoyad = table.Column<string>(type: "text", nullable: false),
                    Cinsiyet = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uye", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OduncKitap",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UyeId = table.Column<int>(type: "integer", nullable: false),
                    KitapId = table.Column<int>(type: "integer", nullable: false),
                    VerilisTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 5, 15, 12, 29, 6, 255, DateTimeKind.Utc).AddTicks(9264)),
                    AlinisTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 5, 15, 12, 29, 6, 255, DateTimeKind.Utc).AddTicks(8659))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OduncKitap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OduncKitap_Kitaplar_KitapId",
                        column: x => x.KitapId,
                        principalTable: "Kitaplar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OduncKitap_Uye_UyeId",
                        column: x => x.UyeId,
                        principalTable: "Uye",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OduncKitap_KitapId",
                table: "OduncKitap",
                column: "KitapId");

            migrationBuilder.CreateIndex(
                name: "IX_OduncKitap_UyeId",
                table: "OduncKitap",
                column: "UyeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OduncKitap");

            migrationBuilder.DropTable(
                name: "Uye");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Yazarlar",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 15, 12, 9, 8, 756, DateTimeKind.Utc).AddTicks(5863),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 15, 12, 29, 6, 256, DateTimeKind.Utc).AddTicks(4509));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Raflar",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 15, 12, 9, 8, 756, DateTimeKind.Utc).AddTicks(3448),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 15, 12, 29, 6, 256, DateTimeKind.Utc).AddTicks(2500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kitaplar",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 15, 12, 9, 8, 755, DateTimeKind.Utc).AddTicks(8400),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 15, 12, 29, 6, 255, DateTimeKind.Utc).AddTicks(4868));
        }
    }
}
