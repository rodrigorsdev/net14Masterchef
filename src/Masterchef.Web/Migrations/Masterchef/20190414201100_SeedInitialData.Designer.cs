﻿// <auto-generated />
using System;
using Masterchef.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Masterchef.Web.Migrations.Masterchef
{
    [DbContext(typeof(MasterchefContext))]
    [Migration("20190414201100_SeedInitialData")]
    partial class SeedInitialData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Masterchef.Domain.Categoria.Entity.Categoria", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddDate");

                    b.Property<int>("CascadeMode");

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Categoria");

                    b.HasData(
                        new
                        {
                            Id = new Guid("57e7515e-8285-43e6-b6c0-ec7b9890a879"),
                            AddDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CascadeMode = 0,
                            Descricao = "Bolos",
                            Nome = "Bolos"
                        },
                        new
                        {
                            Id = new Guid("ef659695-a1f8-4740-a974-8e563a9e12bd"),
                            AddDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CascadeMode = 0,
                            Descricao = "Tortas",
                            Nome = "Tortas"
                        },
                        new
                        {
                            Id = new Guid("c7985033-24b1-4cca-84d9-0face1199031"),
                            AddDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CascadeMode = 0,
                            Descricao = "Carnes",
                            Nome = "Carnes"
                        },
                        new
                        {
                            Id = new Guid("4f31f332-5a04-4bde-a999-ad0f8ac728e2"),
                            AddDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CascadeMode = 0,
                            Descricao = "Aves",
                            Nome = "Aves"
                        },
                        new
                        {
                            Id = new Guid("34890e59-8e05-4628-9060-478cd9d98193"),
                            AddDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CascadeMode = 0,
                            Descricao = "Massas",
                            Nome = "Massas"
                        },
                        new
                        {
                            Id = new Guid("1bf37d85-67d2-4c5f-9438-b78e67f0b678"),
                            AddDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CascadeMode = 0,
                            Descricao = "Sopas e caldos",
                            Nome = "Sopas e caldos"
                        },
                        new
                        {
                            Id = new Guid("d163b2d8-8ec0-4f03-8c66-0344d8a10910"),
                            AddDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CascadeMode = 0,
                            Descricao = "Doces",
                            Nome = "Doces"
                        });
                });

            modelBuilder.Entity("Masterchef.Domain.Ingrediente.Entity.Ingrediente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddDate");

                    b.Property<int>("CascadeMode");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("UnidadeMedida")
                        .IsRequired();

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Ingrediente");

                    b.HasData(
                        new
                        {
                            Id = new Guid("eb33f88a-9cf3-4d0b-b762-70f0457ad356"),
                            AddDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CascadeMode = 0,
                            Nome = "Farinha de trigo",
                            UnidadeMedida = "kg"
                        },
                        new
                        {
                            Id = new Guid("250b697b-18cb-4c4b-987a-53ce663b7fb5"),
                            AddDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CascadeMode = 0,
                            Nome = "Ovo",
                            UnidadeMedida = "un"
                        },
                        new
                        {
                            Id = new Guid("27166bba-148f-4082-91ee-bcec547390ed"),
                            AddDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CascadeMode = 0,
                            Nome = "Leite",
                            UnidadeMedida = "ml"
                        },
                        new
                        {
                            Id = new Guid("f994d309-212f-4f9c-8672-6c964ab7b516"),
                            AddDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CascadeMode = 0,
                            Nome = "Sal",
                            UnidadeMedida = "colher chá"
                        },
                        new
                        {
                            Id = new Guid("56e6d958-cb88-4315-8356-73a1f831f872"),
                            AddDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CascadeMode = 0,
                            Nome = "Açucar",
                            UnidadeMedida = "colher sopa"
                        },
                        new
                        {
                            Id = new Guid("8369d249-dcdd-4ba6-85b4-8d0955580163"),
                            AddDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CascadeMode = 0,
                            Nome = "Óleo",
                            UnidadeMedida = "Xicara"
                        },
                        new
                        {
                            Id = new Guid("8974aefa-e989-4027-9e04-d1e1a96a206c"),
                            AddDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CascadeMode = 0,
                            Nome = "Água",
                            UnidadeMedida = "ml"
                        },
                        new
                        {
                            Id = new Guid("df6badb5-159d-42c7-925b-6508c8cecaea"),
                            AddDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CascadeMode = 0,
                            Nome = "Leite em pó",
                            UnidadeMedida = "colher sopa"
                        },
                        new
                        {
                            Id = new Guid("07fa9f48-adbc-47e1-97dc-b6883b300471"),
                            AddDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CascadeMode = 0,
                            Nome = "Amido de milho",
                            UnidadeMedida = "colher sopa"
                        });
                });

            modelBuilder.Entity("Masterchef.Domain.Receita.Entity.Receita", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddDate");

                    b.Property<int>("CascadeMode");

                    b.Property<Guid?>("CategoriaId");

                    b.Property<string>("Descricao");

                    b.Property<byte[]>("Imagem");

                    b.Property<string>("ModoPreparo");

                    b.Property<string>("Tags");

                    b.Property<string>("Titulo");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Receita");
                });

            modelBuilder.Entity("Masterchef.Domain.Receita.Entity.ReceitaIngrediente", b =>
                {
                    b.Property<Guid>("ReceitaId");

                    b.Property<Guid>("IngredienteId");

                    b.Property<int>("Quantidade");

                    b.HasKey("ReceitaId", "IngredienteId");

                    b.HasIndex("IngredienteId");

                    b.ToTable("ReceitaIngrediente");
                });

            modelBuilder.Entity("Masterchef.Domain.Receita.Entity.Receita", b =>
                {
                    b.HasOne("Masterchef.Domain.Categoria.Entity.Categoria", "Categoria")
                        .WithMany("Receitas")
                        .HasForeignKey("CategoriaId");
                });

            modelBuilder.Entity("Masterchef.Domain.Receita.Entity.ReceitaIngrediente", b =>
                {
                    b.HasOne("Masterchef.Domain.Ingrediente.Entity.Ingrediente", "Ingrediente")
                        .WithMany("ReceitaIngredientes")
                        .HasForeignKey("IngredienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Masterchef.Domain.Receita.Entity.Receita", "Receita")
                        .WithMany("ReceitaIngredientes")
                        .HasForeignKey("ReceitaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
