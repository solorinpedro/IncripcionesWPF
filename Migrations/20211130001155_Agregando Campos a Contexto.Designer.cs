// <auto-generated />
using System;
using IncripcionesWPF.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IncripcionesWPF.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20211130001155_Agregando Campos a Contexto")]
    partial class AgregandoCamposaContexto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            AreaId = 1,
                            Descripcion = "Biologia"
                        });
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

                    b.HasData(
                        new
                        {
                            CursoId = 1,
                            Codigo = "Inf-200",
                            Nombre = "Informatica"
                        });
                });

            modelBuilder.Entity("IncripcionesWPF.Entidades.CursosDetalle", b =>
                {
                    b.Property<int>("CursoDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CursoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MateriaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CursoDetalleId");

                    b.HasIndex("CursoId");

                    b.HasIndex("MateriaId");

                    b.ToTable("CursosDetalle");
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

                    b.HasData(
                        new
                        {
                            EstudianteId = 1,
                            Apellido = "Lopez",
                            Celular = "809-433-2344",
                            Correo = "Carlos@gmail.com",
                            Direccion = "Villa tapia",
                            FechaNacimiento = new DateTime(2021, 11, 29, 20, 11, 55, 0, DateTimeKind.Local).AddTicks(8050),
                            Nombre = "Carlos",
                            Telefono = "809-887-3454"
                        });
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

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.HasKey("IncripcionId");

                    b.HasIndex("CursoId");

                    b.HasIndex("EstudianteId");

                    b.ToTable("Incripciones");

                    b.HasData(
                        new
                        {
                            IncripcionId = 1,
                            CursoId = 1,
                            EstudianteId = 1,
                            Fecha = new DateTime(2021, 11, 29, 20, 11, 55, 1, DateTimeKind.Local).AddTicks(2336)
                        });
                });

            modelBuilder.Entity("IncripcionesWPF.Entidades.Materias", b =>
                {
                    b.Property<int>("MateriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Codigo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("MateriaId");

                    b.ToTable("Materias");

                    b.HasData(
                        new
                        {
                            MateriaId = 1,
                            Codigo = "Mat-302",
                            Nombre = "Matematicas"
                        });
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

                    b.HasData(
                        new
                        {
                            ProfesorId = 1,
                            Apellidos = "Lopez",
                            AreaId = 1,
                            Celular = "890-123-3343",
                            Correo = "Johan@gmail.com",
                            Direccion = "Cenovi",
                            FechaIngreso = new DateTime(2021, 11, 29, 20, 11, 55, 1, DateTimeKind.Local).AddTicks(6901),
                            FechaNacimiento = new DateTime(2021, 11, 29, 20, 11, 55, 1, DateTimeKind.Local).AddTicks(7151),
                            Nombres = "Johan",
                            Telefono = "908-234-1234"
                        });
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
                            Clave = "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4",
                            FechaCreacion = new DateTime(2021, 11, 29, 20, 11, 55, 2, DateTimeKind.Local).AddTicks(37),
                            Nombre = "Carlos",
                            NombreUsuario = "Admin",
                            RolId = 1
                        });
                });

            modelBuilder.Entity("IncripcionesWPF.Entidades.CursosDetalle", b =>
                {
                    b.HasOne("IncripcionesWPF.Entidades.Cursos", "Cursos")
                        .WithMany("Detalle")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IncripcionesWPF.Entidades.Materias", "Materias")
                        .WithMany()
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cursos");

                    b.Navigation("Materias");
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
