﻿// <auto-generated />
using GeremyDelosSantos_Ap1_P1.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeremyDelosSantos_Ap1_P1.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240923234004_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("GeremyDelosSantos_Ap1_P1.Models.Registro", b =>
                {
                    b.Property<string>("RegistroId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RegistroId");

                    b.ToTable("Registro");
                });
#pragma warning restore 612, 618
        }
    }
}
