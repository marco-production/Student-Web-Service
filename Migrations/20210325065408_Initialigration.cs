using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Student_Web_Service.Migrations
{
    public partial class Initialigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Cedula = table.Column<string>(type: "nvarchar(13)", nullable: true),
                    Carrera = table.Column<string>(type: "nvarchar(35)", nullable: true),
                    CreditosAprobados = table.Column<int>(type: "int", nullable: false),
                    Indice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CondicionAcademica = table.Column<string>(type: "nvarchar(1)", nullable: true),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
