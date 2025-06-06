﻿// <auto-generated />
using System;
using EasyPark.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EasyPark.Infrastructure.Migrations
{
    [DbContext(typeof(EasyParkContext))]
    [Migration("20250330013708_AtualizacaoBanco")]
    partial class AtualizacaoBanco
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EasyPark.Core.Entities.CarroModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioModelId");

                    b.ToTable("Carros");
                });

            modelBuilder.Entity("EasyPark.Core.Entities.ReservaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarroId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataReserva")
                        .HasColumnType("datetime2");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("VagaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarroId");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("VagaId");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("EasyPark.Core.Entities.UsuarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("EasyPark.Core.Entities.VagaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Disponivel")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Vagas");
                });

            modelBuilder.Entity("EasyPark.Core.Entities.CarroModel", b =>
                {
                    b.HasOne("EasyPark.Core.Entities.UsuarioModel", null)
                        .WithMany("Carros")
                        .HasForeignKey("UsuarioModelId");
                });

            modelBuilder.Entity("EasyPark.Core.Entities.ReservaModel", b =>
                {
                    b.HasOne("EasyPark.Core.Entities.CarroModel", "Carro")
                        .WithMany()
                        .HasForeignKey("CarroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyPark.Core.Entities.UsuarioModel", "Usuario")
                        .WithMany("Reservas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyPark.Core.Entities.VagaModel", "Vaga")
                        .WithMany("Reservas")
                        .HasForeignKey("VagaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carro");

                    b.Navigation("Usuario");

                    b.Navigation("Vaga");
                });

            modelBuilder.Entity("EasyPark.Core.Entities.UsuarioModel", b =>
                {
                    b.Navigation("Carros");

                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("EasyPark.Core.Entities.VagaModel", b =>
                {
                    b.Navigation("Reservas");
                });
#pragma warning restore 612, 618
        }
    }
}
