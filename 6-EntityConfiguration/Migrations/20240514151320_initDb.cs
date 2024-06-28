using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _6_EntityConfiguration.Migrations
{
    /// <inheritdoc />
    public partial class initDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branslar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BransAdi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 5, 14, 15, 13, 19, 824, DateTimeKind.Utc).AddTicks(4488))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branslar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sinifar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SinifAdi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Kapasite = table.Column<byte>(type: "smallint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 5, 14, 15, 13, 19, 825, DateTimeKind.Utc).AddTicks(2180))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinifar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ogretmenler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AdSoyad = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Cinsiyet = table.Column<bool>(type: "boolean", nullable: false),
                    BransId = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 5, 14, 15, 13, 19, 824, DateTimeKind.Utc).AddTicks(9661))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogretmenler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogretmenler_Branslar_BransId",
                        column: x => x.BransId,
                        principalTable: "Branslar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AdSoyad = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Cinsiyet = table.Column<bool>(type: "boolean", nullable: false),
                    SinifId = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 5, 14, 15, 13, 19, 824, DateTimeKind.Utc).AddTicks(6804))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogrenciler_Sinifar_SinifId",
                        column: x => x.SinifId,
                        principalTable: "Sinifar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Branslar",
                columns: new[] { "Id", "BransAdi" },
                values: new object[,]
                {
                    { 1, "Matematik" },
                    { 2, "Fizik" },
                    { 3, "Edebiyat" }
                });

            migrationBuilder.InsertData(
                table: "Sinifar",
                columns: new[] { "Id", "Kapasite", "SinifAdi" },
                values: new object[,]
                {
                    { 1, (byte)40, "11 A" },
                    { 2, (byte)50, "11 B" }
                });

            migrationBuilder.InsertData(
                table: "Ogrenciler",
                columns: new[] { "Id", "AdSoyad", "Cinsiyet", "SinifId" },
                values: new object[,]
                {
                    { 1, "Ali yilmaz", true, 1 },
                    { 2, "Veli durmaz", true, 1 },
                    { 3, "Ayse kaya", false, 1 }
                });

            migrationBuilder.InsertData(
                table: "Ogretmenler",
                columns: new[] { "Id", "AdSoyad", "BransId", "Cinsiyet" },
                values: new object[,]
                {
                    { 1, "Fatma Guner", 1, true },
                    { 2, "Hanife Kaçmaz", 2, false },
                    { 3, "Hasan Durmaz", 3, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Branslar_BransAdi",
                table: "Branslar",
                column: "BransAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_SinifId",
                table: "Ogrenciler",
                column: "SinifId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogretmenler_BransId",
                table: "Ogretmenler",
                column: "BransId");

            migrationBuilder.CreateIndex(
                name: "IX_Sinifar_SinifAdi",
                table: "Sinifar",
                column: "SinifAdi",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ogrenciler");

            migrationBuilder.DropTable(
                name: "Ogretmenler");

            migrationBuilder.DropTable(
                name: "Sinifar");

            migrationBuilder.DropTable(
                name: "Branslar");
        }
    }
}
