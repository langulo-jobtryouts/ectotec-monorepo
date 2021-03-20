﻿// <auto-generated />
using System;
using Ectotec.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ectotec.Persistencia.Migraciones
{
    [DbContext(typeof(EctotecContext))]
    [Migration("20210320084626_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("Ectotec.Modelo.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NombreCiudad")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreEstado")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Ciudades");
                });

            modelBuilder.Entity("Ectotec.Modelo.Contacto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CiudadId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CiudadId");

                    b.ToTable("Contactos");
                });

            modelBuilder.Entity("Ectotec.Modelo.Contacto", b =>
                {
                    b.HasOne("Ectotec.Modelo.Ciudad", "Ciudad")
                        .WithMany()
                        .HasForeignKey("CiudadId");

                    b.Navigation("Ciudad");
                });
#pragma warning restore 612, 618
        }
    }
}
