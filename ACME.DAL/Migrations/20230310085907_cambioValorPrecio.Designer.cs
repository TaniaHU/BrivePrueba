﻿// <auto-generated />
using ACME.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ACME.DAL.Migrations
{
    [DbContext(typeof(BaseDatosContext))]
    [Migration("20230310085907_cambioValorPrecio")]
    partial class cambioValorPrecio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ACME.BOL.Modelos.Producto", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("CodigoBarras")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PrecioUnitario")
                        .HasColumnType("float");

                    b.Property<int>("SucursalId")
                        .HasColumnType("int");

                    b.HasKey("ProductoId");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("ACME.BOL.Modelos.Sucursal", b =>
                {
                    b.Property<int>("SucursalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SucursalId");

                    b.ToTable("Sucursal");
                });
#pragma warning restore 612, 618
        }
    }
}
