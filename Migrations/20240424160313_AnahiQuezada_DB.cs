using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnahiQuezada_Examen1P.Migrations
{
    /// <inheritdoc />
    public partial class AnahiQuezada_DB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AQ_CitaMedica",
                columns: table => new
                {
                    AQ_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AQ_Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AQ_Urgente = table.Column<bool>(type: "bit", nullable: false),
                    AQ_Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AQ_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AQ_CitaMedica", x => x.AQ_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AQ_CitaMedica");
        }
    }
}
