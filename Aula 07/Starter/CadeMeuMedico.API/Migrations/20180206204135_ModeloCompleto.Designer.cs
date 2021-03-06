﻿// <auto-generated />
using CadeMeuMedico.API;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CadeMeuMedico.API.Migrations
{
    [DbContext(typeof(CadeMeuMedicoDb))]
    [Migration("20180206204135_ModeloCompleto")]
    partial class ModeloCompleto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CadeMeuMedico.API.Model.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("CadeMeuMedico.API.Model.Especialidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("CadeMeuMedico.API.Model.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CidadeId");

                    b.Property<int>("EspecialidadeId");

                    b.Property<string>("Nome");

                    b.Property<string>("NumeroCelula");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.HasIndex("EspecialidadeId");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("CadeMeuMedico.API.Model.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .HasMaxLength(100);

                    b.Property<string>("Login")
                        .HasMaxLength(50);

                    b.Property<string>("Nome")
                        .HasMaxLength(100);

                    b.Property<string>("Senha")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("CadeMeuMedico.API.Model.Medico", b =>
                {
                    b.HasOne("CadeMeuMedico.API.Model.Cidade", "Cidade")
                        .WithMany("Medicos")
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CadeMeuMedico.API.Model.Especialidade", "Especialidade")
                        .WithMany("Medicos")
                        .HasForeignKey("EspecialidadeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
