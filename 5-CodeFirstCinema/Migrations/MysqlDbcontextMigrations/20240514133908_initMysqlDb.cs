using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace _5_CodeFirstCinema.Migrations.MysqlDbcontextMigrations
{
    /// <inheritdoc />
    public partial class initMysqlDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    KategoriAdi = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2024, 5, 14, 16, 39, 7, 583, DateTimeKind.Local).AddTicks(4878))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Salonlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    SalonAdi = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Kapasite = table.Column<byte>(type: "tinyint unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salonlar", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Seans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    SeansAdi = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seans", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Yonetmen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AdSoyad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Cinsiyet = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yonetmen", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Filmler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FilmAdi = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    YonetmenId = table.Column<int>(type: "int", nullable: false)
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
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Gosterim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FilmId = table.Column<int>(type: "int", nullable: false),
                    SenanId = table.Column<int>(type: "int", nullable: false),
                    SeansId = table.Column<int>(type: "int", nullable: false),
                    SalonId = table.Column<int>(type: "int", nullable: false)
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
                })
                .Annotation("MySQL:Charset", "utf8mb4");

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
