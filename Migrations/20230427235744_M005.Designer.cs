﻿// <auto-generated />
using System;
using Commpay.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Commpay.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230427235744_M005")]
    partial class M005
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Commpay.Models.ItemVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Id_Produto")
                        .HasColumnType("int");

                    b.Property<int>("Id_Venda")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Produto");

                    b.HasIndex("Id_Venda");

                    b.ToTable("ItemVenda");
                });

            modelBuilder.Entity("Commpay.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("Commpay.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cargo")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Usuario", (string)null);

                    b.HasDiscriminator<int>("Cargo").HasValue(0);

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Commpay.Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data_Compra")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data_Entrega")
                        .HasColumnType("datetime2");

                    b.Property<string>("Entregador")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Usuario")
                        .HasColumnType("int");

                    b.Property<string>("Valor_Total")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VendaId")
                        .HasColumnType("int");

                    b.Property<string>("Vendedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Usuario");

                    b.HasIndex("VendaId");

                    b.ToTable("Venda");
                });

            modelBuilder.Entity("Commpay.Models.Expedidor", b =>
                {
                    b.HasBaseType("Commpay.Models.Usuario");

                    b.ToTable("Usuario");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("Commpay.Models.Financeiro", b =>
                {
                    b.HasBaseType("Commpay.Models.Usuario");

                    b.ToTable("Usuario");

                    b.HasDiscriminator().HasValue(3);
                });

            modelBuilder.Entity("Commpay.Models.Vendedor", b =>
                {
                    b.HasBaseType("Commpay.Models.Usuario");

                    b.ToTable("Usuario");

                    b.HasDiscriminator().HasValue(2);
                });

            modelBuilder.Entity("Commpay.Models.ItemVenda", b =>
                {
                    b.HasOne("Commpay.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("Id_Produto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Commpay.Models.Venda", "Venda")
                        .WithMany()
                        .HasForeignKey("Id_Venda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");

                    b.Navigation("Venda");
                });

            modelBuilder.Entity("Commpay.Models.Produto", b =>
                {
                    b.HasOne("Commpay.Models.Produto", null)
                        .WithMany("Produtos")
                        .HasForeignKey("ProdutoId");
                });

            modelBuilder.Entity("Commpay.Models.Usuario", b =>
                {
                    b.HasOne("Commpay.Models.Usuario", null)
                        .WithMany("Usuarios")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("Commpay.Models.Venda", b =>
                {
                    b.HasOne("Commpay.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("Id_Usuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Commpay.Models.Venda", null)
                        .WithMany("Vendas")
                        .HasForeignKey("VendaId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Commpay.Models.Produto", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("Commpay.Models.Usuario", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Commpay.Models.Venda", b =>
                {
                    b.Navigation("Vendas");
                });
#pragma warning restore 612, 618
        }
    }
}
