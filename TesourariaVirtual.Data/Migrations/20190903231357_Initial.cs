using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TesourariaVirtual.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carteira",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    ValorInicial = table.Column<decimal>(nullable: true),
                    HexColor = table.Column<string>(nullable: true),
                    TipoCarteira = table.Column<int>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carteira", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConfiguracaoGeral",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfiguracaoGeral", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoGasto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    HexColor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoGasto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoRenda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    HexColor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoRenda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gasto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoGastoId = table.Column<int>(nullable: false),
                    Valor = table.Column<decimal>(nullable: false),
                    DataEntrada = table.Column<DateTime>(nullable: false),
                    CarteiraId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gasto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gasto_Carteira_CarteiraId",
                        column: x => x.CarteiraId,
                        principalTable: "Carteira",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Gasto_TipoGasto_TipoGastoId",
                        column: x => x.TipoGastoId,
                        principalTable: "TipoGasto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Renda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoRendaId = table.Column<int>(nullable: false),
                    Valor = table.Column<decimal>(nullable: false),
                    DataEntrada = table.Column<DateTime>(nullable: false),
                    CarteiraId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Renda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Renda_Carteira_CarteiraId",
                        column: x => x.CarteiraId,
                        principalTable: "Carteira",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Renda_TipoRenda_TipoRendaId",
                        column: x => x.TipoRendaId,
                        principalTable: "TipoRenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gasto_CarteiraId",
                table: "Gasto",
                column: "CarteiraId");

            migrationBuilder.CreateIndex(
                name: "IX_Gasto_TipoGastoId",
                table: "Gasto",
                column: "TipoGastoId");

            migrationBuilder.CreateIndex(
                name: "IX_Renda_CarteiraId",
                table: "Renda",
                column: "CarteiraId");

            migrationBuilder.CreateIndex(
                name: "IX_Renda_TipoRendaId",
                table: "Renda",
                column: "TipoRendaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConfiguracaoGeral");

            migrationBuilder.DropTable(
                name: "Gasto");

            migrationBuilder.DropTable(
                name: "Renda");

            migrationBuilder.DropTable(
                name: "TipoGasto");

            migrationBuilder.DropTable(
                name: "Carteira");

            migrationBuilder.DropTable(
                name: "TipoRenda");
        }
    }
}
