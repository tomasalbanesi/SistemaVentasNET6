using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVentasNET6.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasNET6.DAL.EntityConfig
{
    public class DetalleVentaConfig : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.HasKey(prop => prop.IdDetalleVenta);

            builder.HasOne(dv => dv.Venta)
            .WithMany(v => v.DetallesVentas)
            .HasForeignKey(dv => dv.IdVenta);

            builder.HasOne(dv => dv.Producto)
            .WithMany(p => p.DetallesVentas)
            .HasForeignKey(dv => dv.IdProducto);
        }
    }
}
