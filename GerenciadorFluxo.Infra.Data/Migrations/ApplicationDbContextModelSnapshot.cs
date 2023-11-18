﻿// <auto-generated />
using System;
using GerenciadorFluxo.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GerenciadorFluxo.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GerenciadorFluxo.Domain.Entities.Anotacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("Descricao");

                    b.Property<int>("IdProcesso")
                        .HasColumnType("int")
                        .HasColumnName("IdProcesso");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("IdProcesso");

                    b.ToTable("Anotacoes");
                });

            modelBuilder.Entity("GerenciadorFluxo.Domain.Entities.Fluxo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("Descricao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Nome");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Fluxos");
                });

            modelBuilder.Entity("GerenciadorFluxo.Domain.Entities.Processo", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<int>("IdFluxo")
                        .HasColumnType("int")
                        .HasColumnName("IdFluxo");

                    b.Property<int?>("IdProcessoSuperior")
                        .HasColumnType("int")
                        .HasColumnName("IdProcessoSuperior");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Nome");

                    b.Property<byte>("TipoProcesso")
                        .HasColumnType("tinyint ")
                        .HasColumnName("TipoProcesso");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Processos");
                });

            modelBuilder.Entity("GerenciadorFluxo.Domain.Entities.Anotacao", b =>
                {
                    b.HasOne("GerenciadorFluxo.Domain.Entities.Processo", "Processo")
                        .WithMany("Anotacoes")
                        .HasForeignKey("IdProcesso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("IdProcesso");

                    b.Navigation("Processo");
                });

            modelBuilder.Entity("GerenciadorFluxo.Domain.Entities.Processo", b =>
                {
                    b.HasOne("GerenciadorFluxo.Domain.Entities.Fluxo", "Fluxo")
                        .WithMany("Processos")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("IdFluxo");

                    b.Navigation("Fluxo");
                });

            modelBuilder.Entity("GerenciadorFluxo.Domain.Entities.Fluxo", b =>
                {
                    b.Navigation("Processos");
                });

            modelBuilder.Entity("GerenciadorFluxo.Domain.Entities.Processo", b =>
                {
                    b.Navigation("Anotacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
