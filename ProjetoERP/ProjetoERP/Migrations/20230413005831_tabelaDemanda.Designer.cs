﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoErp.Data;

#nullable disable

namespace ProjetoErp.Migrations
{
    [DbContext(typeof(ProjetoDBContext))]
    [Migration("20230413005831_tabelaDemanda")]
    partial class tabelaDemanda
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjetoErp.Models.ClienteModel", b =>
                {
                    b.Property<int>("id_CT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_CT"));

                    b.Property<string>("enderecoEmail_CT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("enderecoLocal_CT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome_CT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numeroTelefone_CT")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_CT");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ProjetoErp.Models.DemandaModel", b =>
                {
                    b.Property<int>("id_DM")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_DM"));

                    b.Property<int>("id_FN")
                        .HasColumnType("int");

                    b.Property<int>("id_PD")
                        .HasColumnType("int");

                    b.Property<int>("quantidadeAdicionada")
                        .HasColumnType("int");

                    b.HasKey("id_DM");

                    b.ToTable("Demandas");
                });

            modelBuilder.Entity("ProjetoErp.Models.FornecedorModel", b =>
                {
                    b.Property<int>("id_FN")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_FN"));

                    b.Property<string>("descricao_FN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("documentoCnpj_FN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("enderecoEmail_FN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("enderecoLocal_FN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome_FN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numeroTelefone_FN")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_FN");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("ProjetoErp.Models.FuncionarioModel", b =>
                {
                    b.Property<int>("id_FN")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_FN"));

                    b.Property<int?>("anoContratacao_FN")
                        .HasMaxLength(250)
                        .HasColumnType("int");

                    b.Property<string>("cargo_FN")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("documentoCpf_FN")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("enderecoEmail_FN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("enderecoLocal_FN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome_FN")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("numeroTelefone_FN")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<double>("salario_FN")
                        .HasMaxLength(250)
                        .HasColumnType("float");

                    b.HasKey("id_FN");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("ProjetoErp.Models.ProdutoModel", b =>
                {
                    b.Property<int>("id_PD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_PD"));

                    b.Property<DateTime>("dataVencimento_PD")
                        .HasColumnType("datetime2");

                    b.Property<string>("descricao_PD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("estoqueMaximo_PD")
                        .HasColumnType("int");

                    b.Property<int>("estoqueMinimo_PD")
                        .HasColumnType("int");

                    b.Property<int>("importancia_PD")
                        .HasColumnType("int");

                    b.Property<string>("nome_PD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("precoCusto_PD")
                        .HasColumnType("float");

                    b.Property<double>("precoVenda_PD")
                        .HasColumnType("float");

                    b.Property<int>("quantidadeEstoque_PD")
                        .HasColumnType("int");

                    b.Property<int>("status_PD")
                        .HasColumnType("int");

                    b.Property<string>("unidadeMedida_PD")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_PD");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("ProjetoErp.Models.ProdutoVendidoModel", b =>
                {
                    b.Property<int>("id_PV")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_PV"));

                    b.Property<int>("id_PD")
                        .HasColumnType("int");

                    b.Property<string>("nome_PV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("precoUnitario_PV")
                        .HasColumnType("float");

                    b.Property<int>("quantidade_CR")
                        .HasColumnType("int");

                    b.HasKey("id_PV");

                    b.ToTable("Carrinho");
                });

            modelBuilder.Entity("ProjetoErp.Models.VendaModel", b =>
                {
                    b.Property<int>("id_VD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_VD"));

                    b.Property<DateTime>("data_VD")
                        .HasColumnType("datetime2");

                    b.Property<double>("desconto_VD")
                        .HasColumnType("float");

                    b.Property<string>("descricao_VD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_CT")
                        .HasColumnType("int");

                    b.Property<int>("id_FN")
                        .HasColumnType("int");

                    b.Property<int>("metodoPagamento_VD")
                        .HasColumnType("int");

                    b.Property<int>("status_VD")
                        .HasColumnType("int");

                    b.Property<int>("tipoVenda_VD")
                        .HasColumnType("int");

                    b.Property<double>("valorTotal_VD")
                        .HasColumnType("float");

                    b.HasKey("id_VD");

                    b.ToTable("Vendas");
                });
#pragma warning restore 612, 618
        }
    }
}
