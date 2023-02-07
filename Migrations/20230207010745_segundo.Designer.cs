﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using apiCOVID.Data;

#nullable disable

namespace apiCOVID.Migrations
{
    [DbContext(typeof(apiCovidDBContext))]
    [Migration("20230207010745_segundo")]
    partial class segundo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("apiCOVID.Models.CovidModel", b =>
                {
                    b.Property<int>("Recuperadosnovos")
                        .HasColumnType("integer");

                    b.Property<int?>("casosAcumulado")
                        .HasColumnType("integer");

                    b.Property<int?>("casosNovos")
                        .HasColumnType("integer");

                    b.Property<int?>("codRegiaoSaude")
                        .HasColumnType("integer");

                    b.Property<int?>("codmun")
                        .HasColumnType("integer");

                    b.Property<int>("coduf")
                        .HasColumnType("integer");

                    b.Property<DateTime>("data")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("emAcompanhamentoNovos")
                        .HasColumnType("integer");

                    b.Property<string>("estado")
                        .HasColumnType("text");

                    b.Property<int?>("interiorOUmetropolitana")
                        .HasColumnType("integer");

                    b.Property<string>("municipio")
                        .HasColumnType("text");

                    b.Property<string>("nomeRegiaoSaude")
                        .HasColumnType("text");

                    b.Property<int?>("obitosAcumulado")
                        .HasColumnType("integer");

                    b.Property<int?>("obitosNovos")
                        .HasColumnType("integer");

                    b.Property<int?>("populacaoTCU2019")
                        .HasColumnType("integer");

                    b.Property<string>("regiao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("semanaEpi")
                        .HasColumnType("integer");

                    b.ToTable("CovidDados");
                });
#pragma warning restore 612, 618
        }
    }
}
