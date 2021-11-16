﻿// <auto-generated />
using System;
using IncripcionesWPF.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IncripcionesWPF.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("IncripcionesWPF.Entidades.Areas", b =>
                {
                    b.Property<int>("AreaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("AreaId");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("IncripcionesWPF.Entidades.Cursos", b =>
                {
                    b.Property<int>("CursoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Codigo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("CursoId");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("IncripcionesWPF.Entidades.Estudiantes", b =>
                {
                    b.Property<int>("EstudianteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .HasColumnType("TEXT");

                    b.Property<string>("Celular")
                        .HasColumnType("TEXT");

                    b.Property<string>("Correo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.HasKey("EstudianteId");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("IncripcionesWPF.Entidades.Incripciones", b =>
                {
                    b.Property<int>("IncripcionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CursoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EstudianteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fecha")
                        .HasColumnType("INTEGER");

                    b.HasKey("IncripcionId");

                    b.HasIndex("CursoId");

                    b.HasIndex("EstudianteId");

                    b.ToTable("Incripciones");
                });

            modelBuilder.Entity("IncripcionesWPF.Entidades.Materias", b =>
                {
                    b.Property<int>("MateriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CodigoMateria")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("MateriaId");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("IncripcionesWPF.Entidades.Profesores", b =>
                {
                    b.Property<int>("ProfesorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellidos")
                        .HasColumnType("TEXT");

                    b.Property<int>("AreaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Celular")
                        .HasColumnType("TEXT");

                    b.Property<string>("Correo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.HasKey("ProfesorId");

                    b.HasIndex("AreaId");

                    b.ToTable("Profesores");
                });

            modelBuilder.Entity("IncripcionesWPF.Entidades.ProfesoresDetalle", b =>
                {
                    b.Property<int>("ProfesorDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MateriaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProfesorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProfesorDetalleId");

                    b.HasIndex("MateriaId");

                    b.HasIndex("ProfesorId");

                    b.ToTable("ProfesoresDetalle");
                });

            modelBuilder.Entity("IncripcionesWPF.Entidades.Roles", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("RolId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RolId = 1,
                            Descripcion = "Admin"
                        },
                        new
                        {
                            RolId = 2,
                            Descripcion = "Secretaria"
                        });
                });

            modelBuilder.Entity("IncripcionesWPF.Entidades.Usuarios", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .HasColumnType("TEXT");

                    b.Property<string>("Clave")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreUsuario")
                        .HasColumnType("TEXT");

                    b.Property<int>("RolId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UsuarioId");

                    b.HasIndex("RolId");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            UsuarioId = 1,
                            Apellido = "Solorin",
                            Clave = "1234",
                            FechaCreacion = new DateTime(2021, 11, 16, 16, 1, 33, 320, DateTimeKind.Local).AddTicks(4207),
                            Nombre = "Carlos",
                            NombreUsuario = "Admin",
                            RolId = 1
                        });
                });

            modelBuilder.Entity("IncripcionesWPF.Entidades.Cursos", b =>
                {
                    b.HasOne("IncripcionesWPF.Entidades.Cursos", null)
                        .WithMany("Detalle")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IncripcionesWPF.Entidades.Incripciones", b =>
                {
                    b.HasOne("IncripcionesWPF.Entidades.Cursos", "Cursos")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IncripcionesWPF.Entidades.Estudiantes", "Estudiantes")
                        .WithMany()
                        .HasForeignKey("EstudianteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cursos");

                    b.Navigation("Estudiantes");
                });

            modelBuilder.Entity("IncripcionesWPF.Entidades.Profesores", b =>
                {
                    b.HasOne("IncripcionesWPF.Entidades.Areas", "Areas")
                        .WithMany()
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Areas");
                });

            modelBuilder.Entity("IncripcionesWPF.Entidades.ProfesoresDetalle", b =>
                {
                    b.HasOne("IncripcionesWPF.Entidades.Materias", "Materias")
                        .WithMany()
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IncripcionesWPF.Entidades.Profesores", "Profesores")
                        .WithMany("Detalle")
                        .HasForeignKey("ProfesorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Materias");

                    b.Navigation("Profesores");
                });

            modelBuilder.Entity("IncripcionesWPF.Entidades.Usuarios", b =>
                {
                    b.HasOne("IncripcionesWPF.Entidades.Roles", "Roles")
                        .WithMany()
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("IncripcionesWPF.Entidades.Cursos", b =>
                {
                    b.Navigation("Detalle");
                });

            modelBuilder.Entity("IncripcionesWPF.Entidades.Profesores", b =>
                {
                    b.Navigation("Detalle");
                });
#pragma warning restore 612, 618
        }
    }
}
