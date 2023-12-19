﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TarefasApp.Infra.Data.Contexts;

#nullable disable

namespace TarefasApp.Infra.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231219224946_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TarefasApp.Domain.Entities.Categoria", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("NOME");

                    b.HasKey("Id");

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("CATEGORIA", (string)null);
                });

            modelBuilder.Entity("TarefasApp.Domain.Entities.Tarefa", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<Guid?>("CategoriaId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CATEGORIAID");

                    b.Property<DateTime?>("DataHora")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("DATAHORA");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("DESCRICAO");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("NOME");

                    b.Property<int>("Prioridade")
                        .HasColumnType("int")
                        .HasColumnName("PRIORIDADE");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("TAREFA", (string)null);
                });

            modelBuilder.Entity("TarefasApp.Domain.Entities.Tarefa", b =>
                {
                    b.HasOne("TarefasApp.Domain.Entities.Categoria", "Categoria")
                        .WithMany("Tarefas")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("TarefasApp.Domain.Entities.Categoria", b =>
                {
                    b.Navigation("Tarefas");
                });
#pragma warning restore 612, 618
        }
    }
}
