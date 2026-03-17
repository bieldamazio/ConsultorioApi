using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsultorioApi.Migrations
{
    /// <inheritdoc />
    public partial class editMedico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Especialidade",
                table: "Medicos",
                newName: "Crm");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Crm",
                table: "Medicos",
                newName: "Especialidade");
        }
    }
}
