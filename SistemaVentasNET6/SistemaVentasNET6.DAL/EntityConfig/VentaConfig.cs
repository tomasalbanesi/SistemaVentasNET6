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
    public class VentaConfig : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.HasKey(prop => prop.IdVenta);

            builder.HasOne(v => v.Usuario)
            .WithMany(u => u.Ventas)
            .HasForeignKey(v => v.IdUsuario);

            builder.HasOne(v => v.TipoDocumentoVenta)
            .WithMany(td => td.Ventas)
            .HasForeignKey(v => v.IdTipoDocumentoVenta);

        }
    }
}
