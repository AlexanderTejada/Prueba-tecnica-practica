﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prueba_Tecnica.Datos;

#nullable disable

namespace Prueba_Tecnica.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241223114134_RemoveRequiredFromModel")]
    partial class RemoveRequiredFromModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Prueba_Tecnica.Modelos.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detalle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MetrosCuadrados")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ocupantes")
                        .HasColumnType("int");

                    b.Property<double>("Tarifa")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenidad = "",
                            Detalle = "Detalle de la villa..",
                            FechaActualizacion = new DateTime(2024, 12, 23, 8, 41, 33, 620, DateTimeKind.Local).AddTicks(3514),
                            FechaCreacion = new DateTime(2024, 12, 23, 8, 41, 33, 617, DateTimeKind.Local).AddTicks(6087),
                            ImageUrl = "",
                            MetrosCuadrados = 50,
                            Nombre = "Villa Real",
                            Ocupantes = 5,
                            Tarifa = 200.0
                        },
                        new
                        {
                            Id = 2,
                            Amenidad = "",
                            Detalle = "Detalle de la villa.",
                            FechaActualizacion = new DateTime(2024, 12, 23, 8, 41, 33, 620, DateTimeKind.Local).AddTicks(3759),
                            FechaCreacion = new DateTime(2024, 12, 23, 8, 41, 33, 620, DateTimeKind.Local).AddTicks(3757),
                            ImageUrl = "",
                            MetrosCuadrados = 40,
                            Nombre = "Premium Vista a la Piscina",
                            Ocupantes = 4,
                            Tarifa = 150.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
