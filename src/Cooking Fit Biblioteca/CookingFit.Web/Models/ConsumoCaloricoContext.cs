﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CookingFit.Web.Models;

public partial class ConsumoCaloricoContext : DbContext
{
    public ConsumoCaloricoContext(DbContextOptions<ConsumoCaloricoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cardapio> Cardapios { get; set; }

    public virtual DbSet<Funcionario> Funcionarios { get; set; }

    public virtual DbSet<Ingrediente> Ingredientes { get; set; }

    public virtual DbSet<Ingredientesreceita> Ingredientesreceitas { get; set; }

    public virtual DbSet<Receita> Receitas { get; set; }

    public virtual DbSet<Usuário> Usuários { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cardapio>(entity =>
        {
            entity.HasKey(e => e.IdCardapio);

            entity.ToTable("Cardapio");

            entity.Property(e => e.IdCardapio)
                .ValueGeneratedNever()
                .HasColumnName("id_cardapio");
            entity.Property(e => e.CaloriasCardapio).HasColumnName("calorias_cardapio");
            entity.Property(e => e.Descriçao)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descriçao");
            entity.Property(e => e.IdIngrediente).HasColumnName("id_ingrediente");
            entity.Property(e => e.IdReceita).HasColumnName("id_receita");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Quantidade).HasColumnName("quantidade");

            entity.HasOne(d => d.IdIngredienteNavigation).WithMany(p => p.Cardapios)
                .HasForeignKey(d => d.IdIngrediente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cardapio_Ingredientes");

            entity.HasOne(d => d.IdReceitaNavigation).WithMany(p => p.Cardapios)
                .HasForeignKey(d => d.IdReceita)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cardapio_Receitas");
        });

        modelBuilder.Entity<Funcionario>(entity =>
        {
            entity.HasKey(e => e.IdDepartamento);

            entity.ToTable("funcionario");

            entity.Property(e => e.IdDepartamento)
                .ValueGeneratedNever()
                .HasColumnName("id_departamento");
            entity.Property(e => e.Departamento)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("departamento");
        });

        modelBuilder.Entity<Ingrediente>(entity =>
        {
            entity.HasKey(e => e.IdIngrediente);

            entity.Property(e => e.IdIngrediente)
                .ValueGeneratedNever()
                .HasColumnName("id_ingrediente");
            entity.Property(e => e.Calorias).HasColumnName("calorias");
            entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Peso)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Unidade)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Ingredientesreceita>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DataCriação)
                .HasColumnType("date")
                .HasColumnName("data_criação");
            entity.Property(e => e.IdIngrediente).HasColumnName("id_ingrediente");
            entity.Property(e => e.IdReceita).HasColumnName("id_receita");
            entity.Property(e => e.Quantidade).HasColumnName("quantidade");

            entity.HasOne(d => d.IdIngredienteNavigation).WithMany()
                .HasForeignKey(d => d.IdIngrediente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ingredientesreceitas_Ingredientes");

            entity.HasOne(d => d.IdReceitaNavigation).WithMany()
                .HasForeignKey(d => d.IdReceita)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ingredientesreceitas_Receitas");
        });

        modelBuilder.Entity<Receita>(entity =>
        {
            entity.HasKey(e => e.IdReceita);

            entity.Property(e => e.IdReceita)
                .ValueGeneratedNever()
                .HasColumnName("ID_receita");
            entity.Property(e => e.Ativo).HasColumnName("ativo");
            entity.Property(e => e.Descriçao)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descriçao");
            entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Usuário>(entity =>
        {
            entity.HasKey(e => e.IdUsuario);

            entity.ToTable("Usuário");

            entity.Property(e => e.IdUsuario)
                .ValueGeneratedNever()
                .HasColumnName("id_usuario");
            entity.Property(e => e.Altura)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("altura");
            entity.Property(e => e.Cpf)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CPF");
            entity.Property(e => e.DtNasc)
                .HasColumnType("date")
                .HasColumnName("dt_nasc");
            entity.Property(e => e.EMail)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("e-mail");
            entity.Property(e => e.FormAcademica)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("form_academica");
            entity.Property(e => e.Genero)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("genero");
            entity.Property(e => e.IdCardapio).HasColumnName("id_cardapio");
            entity.Property(e => e.Idade).HasColumnName("idade");
            entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Peso).HasColumnName("peso");
            entity.Property(e => e.Telefone).HasColumnName("telefone");

            entity.HasOne(d => d.IdCardapioNavigation).WithMany(p => p.Usuários)
                .HasForeignKey(d => d.IdCardapio)
                .HasConstraintName("FK_Usuário_Cardapio");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}