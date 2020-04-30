using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class initialSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    TypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.TypeID);
                });

            migrationBuilder.CreateTable(
                name: "PokemonSpecies",
                columns: table => new
                {
                    SpeciesID = table.Column<int>(nullable: false),
                    SpeciesName = table.Column<string>(maxLength: 100, nullable: false),
                    SpeciesDescription = table.Column<string>(maxLength: 500, nullable: false),
                    PrimaryTypeID = table.Column<int>(nullable: false),
                    SecondaryTypeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonSpecies", x => x.SpeciesID);
                    table.ForeignKey(
                        name: "FK_PokemonSpecies_Type_PrimaryTypeID",
                        column: x => x.PrimaryTypeID,
                        principalTable: "Type",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PokemonSpecies_Type_SecondaryTypeID",
                        column: x => x.SecondaryTypeID,
                        principalTable: "Type",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pokemon",
                columns: table => new
                {
                    PokemonID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeciesID = table.Column<int>(nullable: false),
                    PokemonName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon", x => x.PokemonID);
                    table.ForeignKey(
                        name: "FK_Pokemon_PokemonSpecies_SpeciesID",
                        column: x => x.SpeciesID,
                        principalTable: "PokemonSpecies",
                        principalColumn: "SpeciesID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_SpeciesID",
                table: "Pokemon",
                column: "SpeciesID");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpecies_PrimaryTypeID",
                table: "PokemonSpecies",
                column: "PrimaryTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpecies_SecondaryTypeID",
                table: "PokemonSpecies",
                column: "SecondaryTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemon");

            migrationBuilder.DropTable(
                name: "PokemonSpecies");

            migrationBuilder.DropTable(
                name: "Type");
        }
    }
}
