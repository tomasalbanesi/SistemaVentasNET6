using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SistemaVentasNET6.Entity;

namespace SistemaVentasNET6.DAL.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly();
            // Configura las relaciones adicionales aquí
            modelBuilder.Entity<RolMenu>()
                .HasOne(rm => rm.Rol)
                .WithMany(r => r.RolesMenus)
                .HasForeignKey(rm => rm.IdRol);

            modelBuilder.Entity<RolMenu>()
                .HasOne(rm => rm.Menu)
                .WithMany(m => m.RolesMenus)
                .HasForeignKey(rm => rm.IdMenu);

            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Rol)
                .WithMany(r => r.Usuarios)
                .HasForeignKey(u => u.IdRol);

            modelBuilder.Entity<Producto>()
                .HasOne(p => p.Categoria)
                .WithMany(c => c.Productos)
                .HasForeignKey(p => p.IdCategoria);

            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Usuario)
                .WithMany(u => u.Ventas)
                .HasForeignKey(v => v.IdUsuario);

            modelBuilder.Entity<Venta>()
                .HasOne(v => v.TipoDocumentoVenta)
                .WithMany(td => td.Ventas)
                .HasForeignKey(v => v.IdTipoDocumentoVenta);

            modelBuilder.Entity<DetalleVenta>()
                .HasOne(dv => dv.Venta)
                .WithMany(v => v.DetallesVentas)
                .HasForeignKey(dv => dv.IdVenta);

            modelBuilder.Entity<DetalleVenta>()
                .HasOne(dv => dv.Producto)
                .WithMany(p => p.DetallesVentas)
                .HasForeignKey(dv => dv.IdProducto);
        }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<RolMenu> RolesMenus { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<NumeroCorrelativo> NumerosCorrelativos { get; set; }
        public DbSet<TipoDocumentoVenta> TiposDocumentosVenta { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> DetallesVentas { get; set; }
        public DbSet<Negocio> Negocios { get; set; }
        public DbSet<Configuracion> Configuraciones { get; set; }
    }
}
