using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestion_CyberCafe.Migrations
{
    /// <inheritdoc />
    public partial class FixSeance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Connexions_Employes_EmployeIdEmploye",
                table: "Connexions");

            migrationBuilder.DropForeignKey(
                name: "FK_Connexions_Postes_PosteIdPoste",
                table: "Connexions");

            migrationBuilder.DropForeignKey(
                name: "FK_Paiements_Seances_SeanceIdSeance",
                table: "Paiements");

            migrationBuilder.CreateIndex(
                name: "IX_Seances_IdClient",
                table: "Seances",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_Seances_IdConnexion",
                table: "Seances",
                column: "IdConnexion");

            migrationBuilder.CreateIndex(
                name: "IX_Seances_IdPoste",
                table: "Seances",
                column: "IdPoste");

            migrationBuilder.AddForeignKey(
                name: "FK_Connexions_Employes_EmployeIdEmploye",
                table: "Connexions",
                column: "EmployeIdEmploye",
                principalTable: "Employes",
                principalColumn: "IdEmploye",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Connexions_Postes_PosteIdPoste",
                table: "Connexions",
                column: "PosteIdPoste",
                principalTable: "Postes",
                principalColumn: "IdPoste",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Paiements_Seances_SeanceIdSeance",
                table: "Paiements",
                column: "SeanceIdSeance",
                principalTable: "Seances",
                principalColumn: "IdSeance",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seances_Clients_IdClient",
                table: "Seances",
                column: "IdClient",
                principalTable: "Clients",
                principalColumn: "IdClient");

            migrationBuilder.AddForeignKey(
                name: "FK_Seances_Connexions_IdConnexion",
                table: "Seances",
                column: "IdConnexion",
                principalTable: "Connexions",
                principalColumn: "IdConnexion");

            migrationBuilder.AddForeignKey(
                name: "FK_Seances_Postes_IdPoste",
                table: "Seances",
                column: "IdPoste",
                principalTable: "Postes",
                principalColumn: "IdPoste");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Connexions_Employes_EmployeIdEmploye",
                table: "Connexions");

            migrationBuilder.DropForeignKey(
                name: "FK_Connexions_Postes_PosteIdPoste",
                table: "Connexions");

            migrationBuilder.DropForeignKey(
                name: "FK_Paiements_Seances_SeanceIdSeance",
                table: "Paiements");

            migrationBuilder.DropForeignKey(
                name: "FK_Seances_Clients_IdClient",
                table: "Seances");

            migrationBuilder.DropForeignKey(
                name: "FK_Seances_Connexions_IdConnexion",
                table: "Seances");

            migrationBuilder.DropForeignKey(
                name: "FK_Seances_Postes_IdPoste",
                table: "Seances");

            migrationBuilder.DropIndex(
                name: "IX_Seances_IdClient",
                table: "Seances");

            migrationBuilder.DropIndex(
                name: "IX_Seances_IdConnexion",
                table: "Seances");

            migrationBuilder.DropIndex(
                name: "IX_Seances_IdPoste",
                table: "Seances");

            migrationBuilder.AddForeignKey(
                name: "FK_Connexions_Employes_EmployeIdEmploye",
                table: "Connexions",
                column: "EmployeIdEmploye",
                principalTable: "Employes",
                principalColumn: "IdEmploye");

            migrationBuilder.AddForeignKey(
                name: "FK_Connexions_Postes_PosteIdPoste",
                table: "Connexions",
                column: "PosteIdPoste",
                principalTable: "Postes",
                principalColumn: "IdPoste");

            migrationBuilder.AddForeignKey(
                name: "FK_Paiements_Seances_SeanceIdSeance",
                table: "Paiements",
                column: "SeanceIdSeance",
                principalTable: "Seances",
                principalColumn: "IdSeance");
        }
    }
}
