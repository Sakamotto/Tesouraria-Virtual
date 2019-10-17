﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesourariaVirtual.Data.Context;

namespace TesourariaVirtual.Data.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20190903231357_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TesourariaVirtual.Domain.Entities.Carteira", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Descricao");

                    b.Property<string>("HexColor");

                    b.Property<string>("Nome");

                    b.Property<int>("TipoCarteira");

                    b.Property<decimal?>("ValorInicial");

                    b.HasKey("Id");

                    b.ToTable("Carteira");
                });

            modelBuilder.Entity("TesourariaVirtual.Domain.Entities.ConfiguracaoGeral", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("ConfiguracaoGeral");
                });

            modelBuilder.Entity("TesourariaVirtual.Domain.Entities.Gasto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CarteiraId");

                    b.Property<DateTime>("DataEntrada");

                    b.Property<int>("TipoGastoId");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("CarteiraId");

                    b.HasIndex("TipoGastoId");

                    b.ToTable("Gasto");
                });

            modelBuilder.Entity("TesourariaVirtual.Domain.Entities.Renda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CarteiraId");

                    b.Property<DateTime>("DataEntrada");

                    b.Property<int>("TipoRendaId");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("CarteiraId");

                    b.HasIndex("TipoRendaId");

                    b.ToTable("Renda");
                });

            modelBuilder.Entity("TesourariaVirtual.Domain.Entities.TipoGasto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HexColor");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("TipoGasto");
                });

            modelBuilder.Entity("TesourariaVirtual.Domain.Entities.TipoRenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HexColor");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("TipoRenda");
                });

            modelBuilder.Entity("TesourariaVirtual.Domain.Entities.Gasto", b =>
                {
                    b.HasOne("TesourariaVirtual.Domain.Entities.Carteira")
                        .WithMany("Gastos")
                        .HasForeignKey("CarteiraId");

                    b.HasOne("TesourariaVirtual.Domain.Entities.TipoGasto", "TipoGasto")
                        .WithMany()
                        .HasForeignKey("TipoGastoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TesourariaVirtual.Domain.Entities.Renda", b =>
                {
                    b.HasOne("TesourariaVirtual.Domain.Entities.Carteira")
                        .WithMany("Rendas")
                        .HasForeignKey("CarteiraId");

                    b.HasOne("TesourariaVirtual.Domain.Entities.TipoRenda", "TipoRenda")
                        .WithMany()
                        .HasForeignKey("TipoRendaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}