using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Estate_agency.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: true),
                    CategoryDesc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Apartments",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    Square = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    img = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Furniture = table.Column<string>(nullable: true),
                    With_children = table.Column<string>(nullable: true),
                    With_animals = table.Column<string>(nullable: true),
                    isFavorite = table.Column<bool>(nullable: false),
                    idCategory = table.Column<int>(nullable: false),
                    CategoryNameid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.id);
                    table.ForeignKey(
                        name: "FK_Apartments_Category_CategoryNameid",
                        column: x => x.CategoryNameid,
                        principalTable: "Category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_CategoryNameid",
                table: "Apartments",
                column: "CategoryNameid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
