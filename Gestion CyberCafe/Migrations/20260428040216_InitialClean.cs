using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestion_CyberCafe.Migrations
{
    /// <inheritdoc />
    public partial class InitialClean : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    IdClient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.IdClient);
                });

            migrationBuilder.CreateTable(
                name: "Employes",
                columns: table => new
                {
                    IdEmploye = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employes", x => x.IdEmploye);
                });

            migrationBuilder.CreateTable(
                name: "Parametres",
                columns: table => new
                {
                    IdParametre = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomSysteme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrixHeure = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Devise = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametres", x => x.IdParametre);
                });

            migrationBuilder.CreateTable(
                name: "Postes",
                columns: table => new
                {
                    IdPoste = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Statut = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postes", x => x.IdPoste);
                });

            migrationBuilder.CreateTable(
                name: "Connexions",
                columns: table => new
                {
                    IdConnexion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateConnexion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HeureConnexion = table.Column<TimeSpan>(type: "time", nullable: false),
                    Statut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPoste = table.Column<int>(type: "int", nullable: false),
                    IdEmploye = table.Column<int>(type: "int", nullable: false),
                    PosteIdPoste = table.Column<int>(type: "int", nullable: false),
                    EmployeIdEmploye = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Connexions", x => x.IdConnexion);
                    table.ForeignKey(
                        name: "FK_Connexions_Employes_EmployeIdEmploye",
                        column: x => x.EmployeIdEmploye,
                        principalTable: "Employes",
                        principalColumn: "IdEmploye");
                    table.ForeignKey(
                        name: "FK_Connexions_Postes_PosteIdPoste",
                        column: x => x.PosteIdPoste,
                        principalTable: "Postes",
                        principalColumn: "IdPoste");
                });

            migrationBuilder.CreateTable(
                name: "Seances",
                columns: table => new
                {
                    IdSeance = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeureDebut = table.Column<TimeSpan>(type: "time", nullable: false),
                    HeureFin = table.Column<TimeSpan>(type: "time", nullable: false),
                    Prolongation = table.Column<int>(type: "int", nullable: false),
                    IdClient = table.Column<int>(type: "int", nullable: false),
                    IdPoste = table.Column<int>(type: "int", nullable: false),
                    IdConnexion = table.Column<int>(type: "int", nullable: false),
                    ClientIdClient = table.Column<int>(type: "int", nullable: true),
                    ConnexionIdConnexion = table.Column<int>(type: "int", nullable: true),
                    PosteIdPoste = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seances", x => x.IdSeance);
                    table.ForeignKey(
                        name: "FK_Seances_Clients_ClientIdClient",
                        column: x => x.ClientIdClient,
                        principalTable: "Clients",
                        principalColumn: "IdClient");
                    table.ForeignKey(
                        name: "FK_Seances_Connexions_ConnexionIdConnexion",
                        column: x => x.ConnexionIdConnexion,
                        principalTable: "Connexions",
                        principalColumn: "IdConnexion");
                    table.ForeignKey(
                        name: "FK_Seances_Postes_PosteIdPoste",
                        column: x => x.PosteIdPoste,
                        principalTable: "Postes",
                        principalColumn: "IdPoste");
                });

            migrationBuilder.CreateTable(
                name: "Paiements",
                columns: table => new
                {
                    IdPaiement = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Montant = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    DatePaiement = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModePaiement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Statut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdSeance = table.Column<int>(type: "int", nullable: false),
                    SeanceIdSeance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paiements", x => x.IdPaiement);
                    table.ForeignKey(
                        name: "FK_Paiements_Seances_SeanceIdSeance",
                        column: x => x.SeanceIdSeance,
                        principalTable: "Seances",
                        principalColumn: "IdSeance");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Connexions_EmployeIdEmploye",
                table: "Connexions",
                column: "EmployeIdEmploye");

            migrationBuilder.CreateIndex(
                name: "IX_Connexions_PosteIdPoste",
                table: "Connexions",
                column: "PosteIdPoste");

            migrationBuilder.CreateIndex(
                name: "IX_Paiements_SeanceIdSeance",
                table: "Paiements",
                column: "SeanceIdSeance");

            migrationBuilder.CreateIndex(
                name: "IX_Seances_ClientIdClient",
                table: "Seances",
                column: "ClientIdClient");

            migrationBuilder.CreateIndex(
                name: "IX_Seances_ConnexionIdConnexion",
                table: "Seances",
                column: "ConnexionIdConnexion");

            migrationBuilder.CreateIndex(
                name: "IX_Seances_PosteIdPoste",
                table: "Seances",
                column: "PosteIdPoste");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paiements");

            migrationBuilder.DropTable(
                name: "Parametres");

            migrationBuilder.DropTable(
                name: "Seances");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Connexions");

            migrationBuilder.DropTable(
                name: "Employes");

            migrationBuilder.DropTable(
                name: "Postes");
        }
    }
}
