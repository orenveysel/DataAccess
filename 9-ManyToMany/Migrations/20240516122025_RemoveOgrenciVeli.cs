using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _9_ManyToMany.Migrations
{
    /// <inheritdoc />
    public partial class RemoveOgrenciVeli : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adress_Ogrenciler_OgrenciId",
                table: "Adress");

            migrationBuilder.DropTable(
                name: "OgrenciOgrenciVeli");

            migrationBuilder.DropTable(
                name: "OgrenciVeli");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adress",
                table: "Adress");

            migrationBuilder.RenameTable(
                name: "Adress",
                newName: "Adres");

            migrationBuilder.RenameIndex(
                name: "IX_Adress_OgrenciId",
                table: "Adres",
                newName: "IX_Adres_OgrenciId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adres",
                table: "Adres",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Adres_Ogrenciler_OgrenciId",
                table: "Adres",
                column: "OgrenciId",
                principalTable: "Ogrenciler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adres_Ogrenciler_OgrenciId",
                table: "Adres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adres",
                table: "Adres");

            migrationBuilder.RenameTable(
                name: "Adres",
                newName: "Adress");

            migrationBuilder.RenameIndex(
                name: "IX_Adres_OgrenciId",
                table: "Adress",
                newName: "IX_Adress_OgrenciId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adress",
                table: "Adress",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "OgrenciVeli",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciVeli", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OgrenciOgrenciVeli",
                columns: table => new
                {
                    OgrencilerId = table.Column<int>(type: "int", nullable: false),
                    VelilerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciOgrenciVeli", x => new { x.OgrencilerId, x.VelilerId });
                    table.ForeignKey(
                        name: "FK_OgrenciOgrenciVeli_OgrenciVeli_VelilerId",
                        column: x => x.VelilerId,
                        principalTable: "OgrenciVeli",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgrenciOgrenciVeli_Ogrenciler_OgrencilerId",
                        column: x => x.OgrencilerId,
                        principalTable: "Ogrenciler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciOgrenciVeli_VelilerId",
                table: "OgrenciOgrenciVeli",
                column: "VelilerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adress_Ogrenciler_OgrenciId",
                table: "Adress",
                column: "OgrenciId",
                principalTable: "Ogrenciler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
