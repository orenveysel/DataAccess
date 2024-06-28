using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace _5_CodeFirstCinema.Migrations.PostgreDb
{
    /// <inheritdoc />
    public partial class initPostgresDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KategoriAdi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 5, 14, 13, 45, 39, 307, DateTimeKind.Utc).AddTicks(9365))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Salonlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SalonAdi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Kapasite = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salonlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SeansAdi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yonetmen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AdSoyad = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Cinsiyet = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yonetmen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filmler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FilmAdi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    KategoriId = table.Column<int>(type: "integer", nullable: false),
                    YonetmenId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filmler_Kategori_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Filmler_Yonetmen_YonetmenId",
                        column: x => x.YonetmenId,
                        principalTable: "Yonetmen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gosterim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FilmId = table.Column<int>(type: "integer", nullable: false),
                    SenanId = table.Column<int>(type: "integer", nullable: false),
                    SeansId = table.Column<int>(type: "integer", nullable: false),
                    SalonId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gosterim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gosterim_Filmler_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Filmler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gosterim_Salonlar_SalonId",
                        column: x => x.SalonId,
                        principalTable: "Salonlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gosterim_Seans_SeansId",
                        column: x => x.SeansId,
                        principalTable: "Seans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filmler_FilmAdi",
                table: "Filmler",
                column: "FilmAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Filmler_KategoriId",
                table: "Filmler",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Filmler_YonetmenId",
                table: "Filmler",
                column: "YonetmenId");

            migrationBuilder.CreateIndex(
                name: "IX_Gosterim_FilmId",
                table: "Gosterim",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Gosterim_SalonId",
                table: "Gosterim",
                column: "SalonId");

            migrationBuilder.CreateIndex(
                name: "IX_Gosterim_SeansId",
                table: "Gosterim",
                column: "SeansId");

            migrationBuilder.CreateIndex(
                name: "IX_Gosterim_SenanId_SalonId_FilmId",
                table: "Gosterim",
                columns: new[] { "SenanId", "SalonId", "FilmId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Salonlar_SalonAdi",
                table: "Salonlar",
                column: "SalonAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seans_SeansAdi",
                table: "Seans",
                column: "SeansAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Yonetmen_AdSoyad",
                table: "Yonetmen",
                column: "AdSoyad",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gosterim");

            migrationBuilder.DropTable(
                name: "Filmler");

            migrationBuilder.DropTable(
                name: "Salonlar");

            migrationBuilder.DropTable(
                name: "Seans");

            migrationBuilder.DropTable(
                name: "Kategori");

            migrationBuilder.DropTable(
                name: "Yonetmen");
        }
    }
}
