﻿// <auto-generated />
using System;
using GerenciamentosCrud.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GerenciamentosCrud.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GerenciamentosCrud.Models.CustomerModels", b =>
                {
                    b.Property<int>("customer_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("customer_id"));

                    b.Property<string>("customer_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer_document")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("customer_is_juridic")
                        .HasColumnType("bit");

                    b.Property<string>("customer_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer_phone_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("customer_id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("GerenciamentosCrud.Models.FarmModels", b =>
                {
                    b.Property<int>("farm_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("farm_id"));

                    b.Property<string>("farm_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("farm_city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("farm_distric")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("farm_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("farm_uf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("farm_id");

                    b.ToTable("Farm");
                });

            modelBuilder.Entity("GerenciamentosCrud.Models.ProdutosModels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double?>("Product_ean_code")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<DateTime?>("Product_expiry_date")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Product_fabrication_date")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Product_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Product_quantity")
                        .IsRequired()
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("GerenciamentosCrud.Models.ShippingModels", b =>
                {
                    b.Property<int>("sp_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("sp_id"));

                    b.Property<string>("sp_cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sp_corporate_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sp_responsible_cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sp_responsible_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sp_responsible_phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("sp_id");

                    b.ToTable("Shipping");
                });

            modelBuilder.Entity("GerenciamentosCrud.Models.TransportModels", b =>
                {
                    b.Property<int>("tp_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("tp_id"));

                    b.Property<int>("sp_id")
                        .HasColumnType("int")
                        .HasColumnName("sp_corporate_name");

                    b.Property<string>("tp_plate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tp_responsible_cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tp_responsible_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tp_responsible_phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tp_size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tp_weight_supported")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("tp_id");

                    b.ToTable("Transport");
                });
#pragma warning restore 612, 618
        }
    }
}
