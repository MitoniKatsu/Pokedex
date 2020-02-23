using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Initial_Create : Migration
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
                name: "SpeciesType",
                columns: table => new
                {
                    PokemonTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimaryTypeID = table.Column<int>(nullable: false),
                    SecondaryTypeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpeciesType", x => x.PokemonTypeID);
                    table.ForeignKey(
                        name: "FK_SpeciesType_Type_PrimaryTypeID",
                        column: x => x.PrimaryTypeID,
                        principalTable: "Type",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SpeciesType_Type_SecondaryTypeID",
                        column: x => x.SecondaryTypeID,
                        principalTable: "Type",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PokemonSpecies",
                columns: table => new
                {
                    SpeciesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeciesName = table.Column<string>(maxLength: 100, nullable: false),
                    SpeciesTypeID = table.Column<int>(nullable: false),
                    SpeciesDescription = table.Column<string>(maxLength: 500, nullable: false),
                    EvolvesFromID = table.Column<int>(nullable: true),
                    EvolvesToID = table.Column<int>(nullable: true),
                    EvolutionLevel = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonSpecies", x => x.SpeciesID);
                    table.ForeignKey(
                        name: "FK_PokemonSpecies_PokemonSpecies_EvolvesFromID",
                        column: x => x.EvolvesFromID,
                        principalTable: "PokemonSpecies",
                        principalColumn: "SpeciesID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PokemonSpecies_PokemonSpecies_EvolvesToID",
                        column: x => x.EvolvesToID,
                        principalTable: "PokemonSpecies",
                        principalColumn: "SpeciesID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PokemonSpecies_SpeciesType_SpeciesTypeID",
                        column: x => x.SpeciesTypeID,
                        principalTable: "SpeciesType",
                        principalColumn: "PokemonTypeID",
                        onDelete: ReferentialAction.Cascade);
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
                column: "SpeciesID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpecies_EvolvesFromID",
                table: "PokemonSpecies",
                column: "EvolvesFromID",
                unique: true,
                filter: "[EvolvesFromID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpecies_EvolvesToID",
                table: "PokemonSpecies",
                column: "EvolvesToID",
                unique: true,
                filter: "[EvolvesToID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpecies_SpeciesTypeID",
                table: "PokemonSpecies",
                column: "SpeciesTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_SpeciesType_PrimaryTypeID",
                table: "SpeciesType",
                column: "PrimaryTypeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SpeciesType_SecondaryTypeID",
                table: "SpeciesType",
                column: "SecondaryTypeID",
                unique: true,
                filter: "[SecondaryTypeID] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemon");

            migrationBuilder.DropTable(
                name: "PokemonSpecies");

            migrationBuilder.DropTable(
                name: "SpeciesType");

            migrationBuilder.DropTable(
                name: "Type");
        }
    }
}
