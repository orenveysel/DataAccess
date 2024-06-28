using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _9_ManyToMany.Migrations
{
    /// <inheritdoc />
    public partial class AddVeliler : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OgrenciOgrenciVeli");

            migrationBuilder.DropTable(
                name: "OgrenciVeli");
        }
    }
}
