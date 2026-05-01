using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestion_CyberCafe.Migrations
{
    /// <inheritdoc />
    public partial class FixConnexionFK : Migration
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

            migrationBuilder.DropIndex(
                name: "IX_Connexions_EmployeIdEmploye",
                table: "Connexions");

            migrationBuilder.DropIndex(
                name: "IX_Connexions_PosteIdPoste",
                table: "Connexions");

            migrationBuilder.DropColumn(
                name: "EmployeIdEmploye",
                table: "Connexions");

            migrationBuilder.DropColumn(
                name: "PosteIdPoste",
                table: "Connexions");

            migrationBuilder.CreateIndex(
                name: "IX_Connexions_IdEmploye",
                table: "Connexions",
                column: "IdEmploye");

            migrationBuilder.CreateIndex(
                name: "IX_Connexions_IdPoste",
                table: "Connexions",
                column: "IdPoste");

            migrationBuilder.AddForeignKey(
                name: "FK_Connexions_Employes_IdEmploye",
                table: "Connexions",
                column: "IdEmploye",
                principalTable: "Employes",
                principalColumn: "IdEmploye",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Connexions_Postes_IdPoste",
                table: "Connexions",
                column: "IdPoste",
                principalTable: "Postes",
                principalColumn: "IdPoste",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Connexions_Employes_IdEmploye",
                table: "Connexions");

            migrationBuilder.DropForeignKey(
                name: "FK_Connexions_Postes_IdPoste",
                table: "Connexions");

            migrationBuilder.DropIndex(
                name: "IX_Connexions_IdEmploye",
                table: "Connexions");

            migrationBuilder.DropIndex(
                name: "IX_Connexions_IdPoste",
                table: "Connexions");

            migrationBuilder.AddColumn<int>(
                name: "EmployeIdEmploye",
                table: "Connexions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PosteIdPoste",
                table: "Connexions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Connexions_EmployeIdEmploye",
                table: "Connexions",
                column: "EmployeIdEmploye");

            migrationBuilder.CreateIndex(
                name: "IX_Connexions_PosteIdPoste",
                table: "Connexions",
                column: "PosteIdPoste");

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
        }
    }
}
