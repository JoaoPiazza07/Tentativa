﻿// <auto-generated />
using System;
using CookingFit_backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CookingFit_backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240526203649_M05-AddTipoIngredienteIdToIngrediente")]
    partial class M05AddTipoIngredienteIdToIngrediente
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CookingFit_backend.Models.Cardapio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Calorias")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quantidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cardapio");
                });

            modelBuilder.Entity("CookingFit_backend.Models.Informacao", b =>
                {
                    b.Property<int>("IdInfo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdInfo"), 1L, 1);

                    b.Property<string>("Biografia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DtNasc")
                        .HasColumnType("datetime2");

                    b.Property<string>("FormAcademica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdInfo");

                    b.ToTable("InfoUser");
                });

            modelBuilder.Entity("CookingFit_backend.Models.Ingrediente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Calorias")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Peso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoIngredienteId")
                        .HasColumnType("int");

                    b.Property<string>("Unidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TipoIngredienteId");

                    b.ToTable("Ingrediente");
                });

            modelBuilder.Entity("CookingFit_backend.Models.TipoIngrediente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoIngrediente");
                });

            modelBuilder.Entity("CookingFit_backend.Models.Ingrediente", b =>
                {
                    b.HasOne("CookingFit_backend.Models.TipoIngrediente", "TipoIngrediente")
                        .WithMany("Ingredientes")
                        .HasForeignKey("TipoIngredienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoIngrediente");
                });

            modelBuilder.Entity("CookingFit_backend.Models.TipoIngrediente", b =>
                {
                    b.Navigation("Ingredientes");
                });
#pragma warning restore 612, 618
        }
    }
}
