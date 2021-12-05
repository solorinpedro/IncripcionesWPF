﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IncripcionesWPF.Migrations
{
    public partial class AgregandoentidadCursosDetallealContexto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 554, DateTimeKind.Local).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 2,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 554, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 3,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 554, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 4,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 554, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 5,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 554, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 554, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 1,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(4971), new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 2,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(5812), new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 3,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(5835), new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 4,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(5852), new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 5,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(5867), new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(8150));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 916, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 2,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 916, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 3,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 916, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 4,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 916, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 5,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 916, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 1,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(6073), new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 2,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(6905), new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 3,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(6932), new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 4,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(6949), new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 5,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(6966), new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(6967) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(9434));
        }
    }
}
