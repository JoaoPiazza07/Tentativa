﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CookingFitDATA.Models;

public partial class ConsumoCaloricoContext : DbContext
{
    public ConsumoCaloricoContext()
    {
    }

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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-95OQ575;Initial Catalog=ConsumoCalorico;Persist Security Info=True;User ID=sa;Password=EinsZweiDrei123!");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cardapio>(entity =>
        {
            entity.Property(e => e.IdCardapio).ValueGeneratedNever();

            entity.HasOne(d => d.IdIngredienteNavigation).WithMany(p => p.Cardapios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cardapio_Ingredientes");

            entity.HasOne(d => d.IdReceitaNavigation).WithMany(p => p.Cardapios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cardapio_Receitas");
        });

        modelBuilder.Entity<Funcionario>(entity =>
        {
            entity.Property(e => e.IdDepartamento).ValueGeneratedNever();
        });

        modelBuilder.Entity<Ingrediente>(entity =>
        {
            entity.Property(e => e.IdIngrediente).ValueGeneratedNever();
        });

        modelBuilder.Entity<Ingredientesreceita>(entity =>
        {
            entity.HasOne(d => d.IdIngredienteNavigation).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ingredientesreceitas_Ingredientes");

            entity.HasOne(d => d.IdReceitaNavigation).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ingredientesreceitas_Receitas");
        });

        modelBuilder.Entity<Receita>(entity =>
        {
            entity.Property(e => e.IdReceita).ValueGeneratedNever();
        });

        modelBuilder.Entity<Usuário>(entity =>
        {
            entity.Property(e => e.IdUsuario).ValueGeneratedNever();

            entity.HasOne(d => d.IdCardapioNavigation).WithMany(p => p.Usuários).HasConstraintName("FK_Usuário_Cardapio");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}