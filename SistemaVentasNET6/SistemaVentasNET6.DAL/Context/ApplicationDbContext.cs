using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SistemaVentasNET6.Entity;
using System.Reflection;

namespace SistemaVentasNET6.DAL.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());            
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
