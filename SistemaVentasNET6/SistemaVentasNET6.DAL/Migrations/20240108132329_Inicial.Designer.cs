﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaVentasNET6.DAL.Context;

#nullable disable

namespace SistemaVentasNET6.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240108132329_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SistemaVentasNET6.Entity.Categoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCategoria"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EsActivo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.HasKey("IdCategoria");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("SistemaVentasNET6.Entity.Configuracion", b =>
                {
                    b.Property<string>("Propiedad")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Recurso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Valor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Propiedad");

                    b.ToTable("Configuraciones");
                });

            modelBuilder.Entity("SistemaVentasNET6.Entity.DetalleVenta", b =>
                {
                    b.Property<int>("IdDetalleVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDetalleVenta"), 1L, 1);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("CategoriaProducto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescripcionProducto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<int>("IdVenta")
                        .HasColumnType("int");

                    b.Property<string>("MarcaProducto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdDetalleVenta");

                    b.HasIndex("IdProducto");

                    b.HasIndex("IdVenta");

                    b.ToTable("DetallesVentas");
                });

            modelBuilder.Entity("SistemaVentasNET6.Entity.Menu", b =>
                {
                    b.Property<int>("IdMenu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMenu"), 1L, 1);

                    b.Property<string>("Controlador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EsActivo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Icono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdMenuPadre")
                        .HasColumnType("int");

                    b.Property<string>("PaginaAccion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMenu");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("SistemaVentasNET6.Entity.Negocio", b =>
                {
                    b.Property<int>("IdNegocio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdNegocio"), 1L, 1);

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PorcentajeImpuesto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SimboloMoneda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlLogo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdNegocio");

                    b.ToTable("Negocios");
                });

            modelBuilder.Entity("SistemaVentasNET6.Entity.NumeroCorrelativo", b =>
                {
                    b.Property<int>("IdNumeroCorrelativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdNumeroCorrelativo"), 1L, 1);

                    b.Property<int>("CantidadDigitos")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gestion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UltimoNumero")
                        .HasColumnType("int");

                    b.HasKey("IdNumeroCorrelativo");

                    b.ToTable("NumerosCorrelativos");
                });

            modelBuilder.Entity("SistemaVentasNET6.Entity.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProducto"), 1L, 1);

                    b.Property<string>("CodigoBarra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EsActivo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCategoria")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreImagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("UrlImagen")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdProducto");

                    b.HasIndex("IdCategoria");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("SistemaVentasNET6.Entity.Rol", b =>
                {
                    b.Property<int>("IdRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRol"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EsActivo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.HasKey("IdRol");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("SistemaVentasNET6.Entity.RolMenu", b =>
                {
                    b.Property<int>("IdRolMenu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRolMenu"), 1L, 1);

                    b.Property<bool>("EsActivo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdMenu")
                        .HasColumnType("int");

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.HasKey("IdRolMenu");

                    b.HasIndex("IdMenu");

                    b.HasIndex("IdRol");

                    b.ToTable("RolesMenus");
                });

            modelBuilder.Entity("SistemaVentasNET6.Entity.TipoDocumentoVenta", b =>
                {
                    b.Property<int>("IdTipoDocumentoVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoDocumentoVenta"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EsActivo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.HasKey("IdTipoDocumentoVenta");

                    b.ToTable("TiposDocumentosVenta");
                });

            modelBuilder.Entity("SistemaVentasNET6.Entity.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"), 1L, 1);

                    b.Property<string>("Clave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EsActivo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreFoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlFoto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("IdRol");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("SistemaVentasNET6.Entity.Venta", b =>
                {
                    b.Property<int>("IdVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVenta"), 1L, 1);

                    b.Property<string>("DocumentoCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdTipoDocumentoVenta")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<decimal>("ImpuestoTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("NombreCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroVenta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdVenta");

                    b.HasIndex("IdTipoDocumentoVenta");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("SistemaVentasNET6.Entity.DetalleVenta", b =>
                {
                    b.HasOne("SistemaVentasNET6.Entity.Producto", "Producto")
                        .WithMany("DetallesVentas")
                        .HasForeignKey("IdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaVentasNET6.Entity.Venta", "Venta")
                        .WithMany("DetallesVentas")
                        .HasForeignKey("IdVenta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("SistemaVentasNET6.Entity.Producto", b =>
                {
                    b.HasOne("SistemaVentasNET6.Entity.Categoria", "Categoria")
                        .WithMany("Productos")
                        .HasForeignKey("IdCategoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("SistemaVentasNET6.Entity.RolMenu", b =>
                {
                    b.HasOne("SistemaVentasNET6.Entity.Menu", "Menu")
                        .WithMany("RolesMenus")
                        .HasForeignKey("IdMenu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaVentasNET6.Entity.Rol", "Rol")
                        .WithMany("RolesMenus")
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("SistemaVentasNET6.Entity.Usuario", b =>
                {
                    b.HasOne("SistemaVentasNET6.Entity.Rol", "Rol")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("SistemaVentasNET6.Entity.Venta", b =>
                {
                    b.HasOne("SistemaVentasNET6.Entity.TipoDocumentoVenta", "TipoDocumentoVenta")
                        .WithMany("Ventas")
                        .HasForeignKey("IdTipoDocumentoVenta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaVentasNET6.Entity.Usuario", "Usuario")
                        .WithMany("Ventas")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoDocumentoVenta");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("SistemaVentasNET6.Entity.Categoria", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("SistemaVentasNET6.Entity.Menu", b =>
                {
                    b.Navigation("RolesMenus");
                });

            modelBuilder.Entity("SistemaVentasNET6.Entity.Producto", b =>
                {
                    b.Navigation("DetallesVentas");
                });

            modelBuilder.Entity("SistemaVentasNET6.Entity.Rol", b =>
                {
                    b.Navigation("RolesMenus");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("SistemaVentasNET6.Entity.TipoDocumentoVenta", b =>
                {
                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("SistemaVentasNET6.Entity.Usuario", b =>
                {
                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("SistemaVentasNET6.Entity.Venta", b =>
                {
                    b.Navigation("DetallesVentas");
                });
#pragma warning restore 612, 618
        }
    }
}