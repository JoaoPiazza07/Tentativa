﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CookingFitDATA.Models;

[Keyless]
public partial class Ingredientesreceita
{
    [Column("id_receita")]
    public int IdReceita { get; set; }

    [Column("id_ingrediente")]
    public int IdIngrediente { get; set; }

    [Column("data_criação", TypeName = "date")]
    public DateTime DataCriação { get; set; }

    [Column("quantidade")]
    public int Quantidade { get; set; }

    [ForeignKey("IdIngrediente")]
    public virtual Ingrediente IdIngredienteNavigation { get; set; }

    [ForeignKey("IdReceita")]
    public virtual Receita IdReceitaNavigation { get; set; }
}