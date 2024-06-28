using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _13_GenelTekrar2.Migrations
{
    /// <inheritdoc />
    public partial class initDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dersler",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DersAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dersler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Adsoyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TcNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Gsm = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Adresler",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ulke = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sehir = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ilce = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CaddeSokak = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    KapiNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PostaKod = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    OgrenciId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adresler_Ogrenciler_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "Ogrenciler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DersOgrenci",
                columns: table => new
                {
                    AldigiDerslerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OgrencilerId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersOgrenci", x => new { x.AldigiDerslerId, x.OgrencilerId });
                    table.ForeignKey(
                        name: "FK_DersOgrenci_Dersler_AldigiDerslerId",
                        column: x => x.AldigiDerslerId,
                        principalTable: "Dersler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DersOgrenci_Ogrenciler_OgrencilerId",
                        column: x => x.OgrencilerId,
                        principalTable: "Ogrenciler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Dersler",
                columns: new[] { "Id", "CreateDate", "DersAdi" },
                values: new object[,]
                {
                    { "452fedd2-1639-4f78-bd37-e5bbfa77491f", new DateTime(2024, 5, 28, 15, 57, 25, 362, DateTimeKind.Local).AddTicks(610), "Edebiyat" },
                    { "74525235-1923-4c13-81aa-1640cda1daa9", new DateTime(2024, 5, 28, 15, 57, 25, 362, DateTimeKind.Local).AddTicks(576), "Matematik" },
                    { "d3f778f1-89a6-4956-8ab4-fc79db623850", new DateTime(2024, 5, 28, 15, 57, 25, 362, DateTimeKind.Local).AddTicks(606), "Kimya" },
                    { "e307264e-1305-417b-a92c-de60015f771d", new DateTime(2024, 5, 28, 15, 57, 25, 362, DateTimeKind.Local).AddTicks(589), "Fizik" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adresler_OgrenciId",
                table: "Adresler",
                column: "OgrenciId");

            migrationBuilder.CreateIndex(
                name: "IX_Dersler_DersAdi",
                table: "Dersler",
                column: "DersAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DersOgrenci_OgrencilerId",
                table: "DersOgrenci",
                column: "OgrencilerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_TcNo",
                table: "Ogrenciler",
                column: "TcNo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adresler");

            migrationBuilder.DropTable(
                name: "DersOgrenci");

            migrationBuilder.DropTable(
                name: "Dersler");

            migrationBuilder.DropTable(
                name: "Ogrenciler");
        }
    }
}
