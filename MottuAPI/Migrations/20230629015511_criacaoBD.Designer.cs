﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MottuAPI.Models;

#nullable disable

namespace MottuAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230629015511_criacaoBD")]
    partial class criacaoBD
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MottuAPI.Models.Aluno", b =>
                {
                    b.Property<int>("AlunoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlunoID"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nota")
                        .HasColumnType("int");

                    b.HasKey("AlunoID");

                    b.ToTable("Alunos");
                });
#pragma warning restore 612, 618
        }
    }
}
